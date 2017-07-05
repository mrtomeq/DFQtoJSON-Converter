using System.ComponentModel.DataAnnotations;
using Models;
using Xunit;
using System.Reflection;

namespace XUnitTest
{
	public class PartKeySetterUnitTest
	{
		[Fact]
		public void SetPartNumberTest()
		{
			string testValue = "test";
			var part = new Part();
			var prop = typeof(Part).GetProperty(nameof(part.Number));
			var key = prop.GetCustomAttribute<DisplayAttribute>().Name;

			DFQtoJSONConverter.Parts.KeySettter.SetProperty(key, testValue, part);
			Assert.Equal(testValue, part.Number);
		}

		[Fact]
		public void SetDescriptionTest()
		{
			string testValue = "test";
			var part = new Part();
			var prop = typeof(Part).GetProperty(nameof(part.Description));
			var key = prop.GetCustomAttribute<DisplayAttribute>().Name;

			DFQtoJSONConverter.Parts.KeySettter.SetProperty(key, testValue, part);
			Assert.Equal(testValue, part.Description);
		}

		[Fact]
		public void SetAbbreviationTest()
		{
			string testValue = "test";
			var part = new Part();
			var prop = typeof(Part).GetProperty(nameof(part.Abbreviation));
			var key = prop.GetCustomAttribute<DisplayAttribute>().Name;

			DFQtoJSONConverter.Parts.KeySettter.SetProperty(key, testValue, part);
			Assert.Equal(testValue, part.Abbreviation);
		}

		[Fact]
		public void SetAmendmentStatusTest()
		{
			string testValue = "test";
			var part = new Part();
			var prop = typeof(Part).GetProperty(nameof(part.AmendmentStatus));
			var key = prop.GetCustomAttribute<DisplayAttribute>().Name;

			DFQtoJSONConverter.Parts.KeySettter.SetProperty(key, testValue, part);
			Assert.Equal(testValue, part.AmendmentStatus);
		}

		[Fact]
		public void SetProductTest()
		{
			string testValue = "test";
			var part = new Part();
			var prop = typeof(Part).GetProperty(nameof(part.Product));
			var key = prop.GetCustomAttribute<DisplayAttribute>().Name;

			DFQtoJSONConverter.Parts.KeySettter.SetProperty(key, testValue, part);
			Assert.Equal(testValue, part.Product);
		}

		[Fact]
		public void SetNumberShortTest()
		{
			string testValue = "test";
			var part = new Part();
			var prop = typeof(Part).GetProperty(nameof(part.NumberShort));
			var key = prop.GetCustomAttribute<DisplayAttribute>().Name;

			DFQtoJSONConverter.Parts.KeySettter.SetProperty(key, testValue, part);
			Assert.Equal(testValue, part.NumberShort);
		}


		[Fact]
		public void SetTypeTest()
		{
			string testValue = "test";
			var part = new Part();
			var prop = typeof(Part).GetProperty(nameof(part.Type));
			var key = prop.GetCustomAttribute<DisplayAttribute>().Name;

			DFQtoJSONConverter.Parts.KeySettter.SetProperty(key, testValue, part);
			Assert.Equal(testValue, part.Type);
		}

		[Fact]
		public void SetCode()
		{
			string testValue = "test";
			var part = new Part();
			var prop = typeof(Part).GetProperty(nameof(part.Code));
			var key = prop.GetCustomAttribute<DisplayAttribute>().Name;

			DFQtoJSONConverter.Parts.KeySettter.SetProperty(key, testValue, part);
			Assert.Equal(testValue, part.Code);
		}

		[Fact]
		public void SetControlItem()
		{
			var testValue = 1;
			var part = new Part();
			var prop = typeof(Part).GetProperty(nameof(part.ControlItem));
			var key = prop.GetCustomAttribute<DisplayAttribute>().Name;

			DFQtoJSONConverter.Parts.KeySettter.SetProperty(key, testValue.ToString(), part);
			Assert.Equal(testValue, part.ControlItem);
		}

		[Fact]
		public void SetVersion()
		{
			string testValue = "test";
			var part = new Part();
			var prop = typeof(Part).GetProperty(nameof(part.Version));
			var key = prop.GetCustomAttribute<DisplayAttribute>().Name;

			DFQtoJSONConverter.Parts.KeySettter.SetProperty(key, testValue, part);
			Assert.Equal(testValue, part.Version);
		}

		[Fact]
		public void SetAnnexId()
		{
			string testValue = "test";
			var part = new Part();
			var prop = typeof(Part).GetProperty(nameof(part.AnnexId));
			var key = prop.GetCustomAttribute<DisplayAttribute>().Name;

			DFQtoJSONConverter.Parts.KeySettter.SetProperty(key, testValue, part);
			Assert.Equal(testValue, part.AnnexId);
		}

		[Fact]
		public void SetIndexId()
		{
			string testValue = "test";
			var part = new Part();
			var prop = typeof(Part).GetProperty(nameof(part.IndexId));
			var key = prop.GetCustomAttribute<DisplayAttribute>().Name;

			DFQtoJSONConverter.Parts.KeySettter.SetProperty(key, testValue, part);
			Assert.Equal(testValue, part.IndexId);
		}
	}
}
