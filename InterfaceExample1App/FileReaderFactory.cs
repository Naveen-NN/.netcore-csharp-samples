namespace InterfaceExample1App
{
    public static class FileReaderFactory
    {
        public static IFileReader GetFileReader()
        {
            string type = "SqlDb";

            IFileReader reader = null;

            switch (type)
            {
                case "Xml":
                    reader = new XmlFileReader();
                    break;
                case "Json":
                    reader = new JsonFileReader();
                    break;
                default:
                    reader = new TextFileReader();
                    break;
            }

            return reader;
        }
    }
}