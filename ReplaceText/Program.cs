namespace ReplaceText
{
    class Program
    {
        private const string SourceFile = @"..\..\..\Documents\Hello.pdf";
        private const string DestinationFile = @"..\..\..\Documents\Hello-Fabien.pdf";
        private const string Find = "##732##";
        private const string Replace = "Fabien Molinet";

        static void Main(string[] args)
        {
            AsposePdf.Replace(SourceFile, DestinationFile, Find, Replace);
        }
    }
}
