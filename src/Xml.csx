#! "netcoreapp2.1"

using System.Xml;
using System.Xml.Linq;

string Beautify() {
    var inputFile = "resource/Xml.xml";
    var xml = File.ReadAllText(inputFile);
    var bd = new StringBuilder();
    var element = XElement.Parse(xml);

    var settings = new XmlWriterSettings {
        Indent = true,
        NewLineOnAttributes = false
    };

    using (var writer = XmlWriter.Create(bd, settings)) {
        element.Save(writer);
    }
    return bd.ToString();
}

var result = Beautify();
Console.WriteLine(result);