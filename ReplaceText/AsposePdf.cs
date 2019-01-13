using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace ReplaceText
{
    class AsposePdf
    {
        public static void Replace(string sourceFile, string destinationFile, string find, string replace)
        {
            var pdf = new Document(sourceFile);
            var absorber = new TextFragmentAbsorber(find);
            absorber.TextReplaceOptions = new TextReplaceOptions(TextReplaceOptions.ReplaceAdjustment.AdjustSpaceWidth);
            pdf.Pages.Accept(absorber);

            foreach (var fragment in absorber.TextFragments)
            {
                fragment.Text = replace;
            }

            pdf.Save(destinationFile);
        }
    }
}
