using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace DFQtoJSONConverter
{
	public class KeySetter<T> where T : class
	{
		public readonly Dictionary<string, Action<string, T, PropertyInfo>> KeySetterLookup = new Dictionary<string, Action<string, T, PropertyInfo>>();
		public readonly Dictionary<string, PropertyInfo> PropertyLookup = new Dictionary<string, PropertyInfo>();

		public KeySetter()
		{
			var props = typeof(T).GetProperties();

			foreach (var propertyInfo in props)
			{
				var displayAttribute = propertyInfo.GetCustomAttribute<DisplayAttribute>();
				if (displayAttribute == null) continue;

				PropertyLookup.Add(displayAttribute.Name, propertyInfo);

				if (propertyInfo.PropertyType == typeof(int))
				{
					KeySetterLookup.Add(displayAttribute.Name, SetIntProperty);
				}
				else if (propertyInfo.PropertyType == typeof(float) || propertyInfo.PropertyType == typeof(float?))
				{
					KeySetterLookup.Add(displayAttribute.Name, SetFloatProperty);
				}
				else if (propertyInfo.PropertyType == typeof(DateTime))
				{
					KeySetterLookup.Add(displayAttribute.Name, SetDateProperty);
				}
				else
				{
					KeySetterLookup.Add(displayAttribute.Name, SetStringProperty);
				}
			}
		}

		public void SetProperty(string key, string value, T dataType)
		{
			if (KeySetterLookup.TryGetValue(key, out Action<string, T, PropertyInfo> keySetterAction))
			{
				keySetterAction?.Invoke(value, dataType, PropertyLookup[key]);
			}
		}

		public void SetStringProperty(string value, T dataType, PropertyInfo propertyInfo)
		{
			propertyInfo.SetValue(dataType, value);
		}

		public void SetIntProperty(string value, T dataType, PropertyInfo propertyInfo)
		{
			if (int.TryParse(value, out int result))
			{
				propertyInfo.SetValue(dataType, result);
			}
		}

		public void SetFloatProperty(string value, T dataType, PropertyInfo propertyInfo)
		{
			if (float.TryParse(value, out float result))
			{
				propertyInfo.SetValue(dataType, result);
			}
		}

		public void SetDateProperty(string value, T dataType, PropertyInfo propertyInfo)
		{
			var date = DateConverter.Convert(value);

			if (date != DateTime.MinValue)
			{
				propertyInfo.SetValue(dataType, date);
			}
		}
	}
}
