using FiasBeta.Entities;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace FiasBeta.Manager
{
	class Program
	{
		static void Main()
		{
			Context context = new Context();
			PropertyInfo[] propertiesInfo = typeof(AddressObject).GetProperties();
			//Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;
			XmlReader xmlReader = XmlReader.Create(@"C:\FiasDb\AS_ADDROBJ_20170929_59beeba5-acf4-4157-86b0-db9f987a2508.xml");
			xmlReader.ReadStartElement();
			int j = context.Addresses.Count();
			int i = 0;
			while (i < j)
			{
				xmlReader.Read();
				i++;
			}
			while (xmlReader.Read())
			{
				AddressObject address = new AddressObject()
				{
					AoGuid = xmlReader.GetAttribute("AOGUID"),
					PlainCode = xmlReader.GetAttribute("PLAINCODE"),
					Code = xmlReader.GetAttribute("CODE"),
					NextId = xmlReader.GetAttribute("NEXTID"),
					PrevId = xmlReader.GetAttribute("PREVID"),
					AoId = xmlReader.GetAttribute("AOID"),
					ParentGuid = xmlReader.GetAttribute("PARENTGUID"),
					ShortName = xmlReader.GetAttribute("SHORTNAME"),
					Oktmo = xmlReader.GetAttribute("OKTMO"),
					Okato = xmlReader.GetAttribute("OKATO"),
					PostalCode = xmlReader.GetAttribute("POSTALCODE"),
					OffName = xmlReader.GetAttribute("OFFNAME"),
					SextCode = xmlReader.GetAttribute("SEXTCODE"),
					ExtrCode = xmlReader.GetAttribute("EXTRCODE"),
					StreetCode = xmlReader.GetAttribute("STREETCODE"),
					PlanCode = xmlReader.GetAttribute("PLANCODE"),
					PlaceCode = xmlReader.GetAttribute("PLACECODE"),
					CtarCode = xmlReader.GetAttribute("CTARCODE"),
					CityCode = xmlReader.GetAttribute("CITYCODE"),
					AreaCode = xmlReader.GetAttribute("AREACODE"),
					AutoCode = xmlReader.GetAttribute("AUTOCODE"),
					RegionCode = xmlReader.GetAttribute("REGIONCODE"),
					FormalName = xmlReader.GetAttribute("FORMALNAME")
				};
				//foreach (PropertyInfo property in propertiesInfo)
				//{
				//	address.GetType().GetProperty(property.Name).SetValue(address, xmlReader.GetAttribute(property.Name.ToUpper()));
				//}
				context.Addresses.Add(address);
				i++;
				if (i >= 100)
				{
					i = 0;
					context.BulkSaveChanges();
					//context.Dispose();
					//context = new Context();
				}
			}
			context.BulkSaveChanges();
		}
	}
}
