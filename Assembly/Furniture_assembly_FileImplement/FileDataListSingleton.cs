using Furniture_assembly_BusinessLogic.Enums;
using Furniture_assembly_FileImplement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;


namespace Furniture_assembly_FileImplement
{
    public class FileDataListSingleton
    {
        private static FileDataListSingleton instance;

        private readonly string ComponentFileName = "Component.xml";

        private readonly string OrderFileName = "Order.xml";

        private readonly string FurnitureFileName = "Furniture.xml";

        private readonly string ClientFileName = "Client.xml";

        private readonly string ImplementerFileName = "Implementer.xml";

        private readonly string MessageInfoFileName = "MessageInfo.xml";

        public List<Component> Components { get; set; }
        public List<Order> Orders { get; set; }
        public List<Furniture> Furnitures { get; set; }
        public List<Client> Clients { get; set; }
        public List<Implementer> Implementers { get; set; }
        public List<MessageInfo> MessageInfoes { get; set; }

        private FileDataListSingleton()
        {
            Components = LoadComponents();
            Orders = LoadOrders();
            Furnitures = LoadFurnitures();
            Clients = LoadClients();
            Implementers = LoadImplementers();
            MessageInfoes = LoadMessageInfoes();
        }

        public static FileDataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new FileDataListSingleton();
            }
            return instance;
        }

        ~FileDataListSingleton()
        {
            SaveComponents();
            SaveOrders();
            SaveFurnitures();
            SaveClients();
            SaveImplementers();
            SaveMessageInfoes();
        }

        private List<Component> LoadComponents()
        {
            var list = new List<Component>();

            if (File.Exists(ComponentFileName))
            {
                XDocument xDocument = XDocument.Load(ComponentFileName);

                var xElements = xDocument.Root.Elements("Component").ToList();

                foreach (var elem in xElements)
                {
                    list.Add(new Component
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ComponentName = elem.Element("ComponentName").Value
                    });
                }
            }
            return list;
        }
        private List<Implementer> LoadImplementers()
        {
            var list = new List<Implementer>();
            if (File.Exists(ImplementerFileName))
            {
                XDocument xDocument = XDocument.Load(ImplementerFileName);
                var xElements = xDocument.Root.Elements("Implementers").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new Implementer
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ImplementerFIO = elem.Element("ImplementerFIO").Value,
                        WorkingTime = Convert.ToInt32(elem.Element("WorkingTime").Value),
                        PauseTime = Convert.ToInt32(elem.Element("PauseTime").Value)
                    });
                }
            }
            return list;
        }
        private List<Furniture> LoadFurnitures()
        {
            var list = new List<Furniture>();
            if (File.Exists(FurnitureFileName))
            {
                XDocument xDocument = XDocument.Load(FurnitureFileName);
                var xElements = xDocument.Root.Elements("Furniture").ToList();
                foreach (var elem in xElements)
                {
                    var furnComp = new Dictionary<int, int>();
                    foreach (var component in
                   elem.Element("FurnitureComponents").Elements("FurnitureComponent").ToList())
                    {
                        furnComp.Add(Convert.ToInt32(component.Element("Key").Value),
                        Convert.ToInt32(component.Element("Value").Value));
                    }
                    list.Add(new Furniture
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        FurnitureName = elem.Element("FurnitureName").Value,
                        Price = Convert.ToDecimal(elem.Element("Price").Value),
                        FurnitureComponents = furnComp
                    });
                }
            }
            return list;
        }
        private List<Order> LoadOrders()
        {
            var list = new List<Order>();
            if (File.Exists(OrderFileName))
            {
                XDocument xDocument = XDocument.Load(OrderFileName);

                var xElements = xDocument.Root.Elements("Order").ToList();

                foreach (var elem in xElements)
                {
                    list.Add(new Order
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ClientId = Convert.ToInt32(elem.Element("ClientId").Value),
                        FurnitureId = Convert.ToInt32(elem.Element("FurnitureId").Value),
                        Count = Convert.ToInt32(elem.Element("Count").Value),
                        Sum = Convert.ToDecimal(elem.Element("Sum").Value),
                        Status = (OrderStatus)Convert.ToInt32(elem.Element("Status").Value),
                        DateCreate = Convert.ToDateTime(elem.Element("DateCreate").Value),
                        DateImplement = (!string.IsNullOrEmpty(elem.Element("DateImplement").Value)) ? Convert.ToDateTime(elem.Element("DateImplement").Value) : (DateTime?)null
                    });
                }
            }
            return list;
        }
        private List<Client> LoadClients()
        {
            var list = new List<Client>();
            if (File.Exists(ClientFileName))
            {
                XDocument xDocument = XDocument.Load(ClientFileName);
                var xElements = xDocument.Root.Elements("Clients").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new Client
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ClientFIO = elem.Element("ClientFIO").Value,
                        Email = elem.Element("Email").Value,
                        Password = elem.Element("Password").Value
                    });
                }
            }
            return list;
        }
        private List<MessageInfo> LoadMessageInfoes()
        {
            var list = new List<MessageInfo>();
            if (File.Exists(MessageInfoFileName))
            {
                XDocument xDocument = XDocument.Load(MessageInfoFileName);
                var xElements = xDocument.Root.Elements("MessageInfo").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new MessageInfo
                    {
                        MessageId = elem.Attribute("Id").Value,
                        ClientId = Convert.ToInt32(elem.Element("ClientId").Value),
                        SenderName = elem.Element("SenderName").Value,
                        Subject = elem.Element("Subject").Value,
                        Body = elem.Element("Body").Value,
                        DateDelivery = Convert.ToDateTime(elem.Element("DateDelivery").Value)
                    });
                }
            }
            return list;
        }
        private void SaveImplementers()
        {
            if (Implementers != null)
            {
                var xElement = new XElement("Implementers");
                foreach (var implementer in Implementers)
                {
                    xElement.Add(new XElement("Implementer",
                    new XAttribute("Id", implementer.Id),
                    new XElement("ImplementerFIO", implementer.ImplementerFIO),
                    new XElement("WorkingTime", implementer.WorkingTime),
                    new XElement("PauseTime", implementer.PauseTime)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(ImplementerFileName);
            }
        }
        private void SaveComponents()
        {
            if (Components != null)
            {
                var xElement = new XElement("Components");

                foreach (var component in Components)
                {
                    xElement.Add(new XElement("Component",
                        new XAttribute("Id", component.Id),
                        new XElement("ComponentName", component.ComponentName)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(ComponentFileName);
            }
        }
        private void SaveFurnitures()
        {
            if (Furnitures != null)
            {
                var xElement = new XElement("Furnitures");

                foreach (var Furniture in Furnitures)
                {
                    var compElement = new XElement("FurnitureComponents");
                    foreach (var component in Furniture.FurnitureComponents)
                    {
                        compElement.Add(new XElement("FurnitureComponent",
                            new XElement("Key", component.Key),
                            new XElement("Value", component.Value)));
                    }
                    xElement.Add(new XElement("Furniture",
                        new XAttribute("Id", Furniture.Id),
                        new XElement("FurnitureName", Furniture.FurnitureName),
                        new XElement("Price", Furniture.Price), compElement));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(FurnitureFileName);
            }
        }
        private void SaveOrders()
        {
            if (Orders != null)
            {
                var xElement = new XElement("Orders");

                foreach (var order in Orders)
                {
                    xElement.Add(new XElement("Order",
                        new XAttribute("Id", order.Id),
                        new XElement("FurnitureId", order.FurnitureId),
                        new XElement("Count", order.Count),
                        new XElement("Sum", order.Sum),
                        new XElement("Status", (int)order.Status),
                        new XElement("DateCreate", order.DateCreate),
                        new XElement("DateImplement", order.DateImplement)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(OrderFileName);
            }
        }
        private void SaveClients()
        {
            if (Clients != null)
            {
                var xElement = new XElement("Clients");
                foreach (var client in Clients)
                {
                    xElement.Add(new XElement("Client",
                    new XAttribute("Id", client.Id),
                    new XElement("ClientFIO", client.ClientFIO),
                     new XElement("Email", client.Email),
                    new XElement("Password", client.Password)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(ClientFileName);
            }
        }
        private void SaveMessageInfoes()
        {
            if (MessageInfoes != null)
            {
                var xElement = new XElement("MessageInfo");
                foreach (var messageInfo in MessageInfoes)
                {
                    xElement.Add(new XElement("MessageInfo",
                        new XAttribute("MessageId", messageInfo.MessageId),
                        new XElement("ClientId", messageInfo.ClientId),
                        new XElement("SenderName", messageInfo.SenderName),
                        new XElement("Subject", messageInfo.Subject),
                        new XElement("Body", messageInfo.Body),
                        new XElement("DateDelivery", messageInfo.DateDelivery)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(MessageInfoFileName);
            }
        }

    }
}