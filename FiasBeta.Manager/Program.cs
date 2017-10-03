using FiasBeta.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Xml;

namespace FiasBeta.Manager
{
	class Program
	{
		static void Main()
		{
			Context context = new Context();
			PropertyInfo[] propertiesInfo = typeof(AddressObject).GetProperties();
			Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;
			XmlReader xmlReader = XmlReader.Create(@"C:\FiasDb\AS_ADDROBJ_20170929_59beeba5-acf4-4157-86b0-db9f987a2508.xml");
			xmlReader.ReadStartElement();
			int i = 0;
			while (xmlReader.Read())
			{
				AddressObject address = new AddressObject();
				foreach (PropertyInfo property in propertiesInfo)
				{
					address.GetType().GetProperty(property.Name).SetValue(address, xmlReader.GetAttribute(property.Name.ToUpper()));
				}
				context.Addresses.Add(address);
				i++;
				if (i == 5000)
				{
					i = 0;
					context.BulkSaveChanges();
					context.Dispose();
					context = new Context();
				}
			}
			context.SaveChanges();
		}
	}
}
