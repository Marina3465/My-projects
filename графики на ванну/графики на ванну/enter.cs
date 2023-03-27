using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.IO;
namespace графики_на_ванну
{
    class enter
    {
        private FileInfo _fileInfo;

        public enter(string fileName)
        {
            if (File.Exists(fileName))
            {
                _fileInfo = new FileInfo(fileName);
            }
            else
            {
                throw new ArgumentException("File not found");
            }
        }

        internal bool Process(Dictionary<string, string> items)
        {
            Microsoft.Office.Interop.Word.Application app = null;
            try
            {
                app = new Microsoft.Office.Interop.Word.Application();
                object file = _fileInfo.FullName;

                object missing = Type.Missing;

                app.Documents.Open(file);

                foreach (var item in items)
                {
                    Microsoft.Office.Interop.Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    object wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue;
                    object replace = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing,
                        Replace: replace);
                }

                object newFileName = Path.Combine(_fileInfo.DirectoryName, DateTime.Now.ToString("yyyyMMdd HHmmss") + _fileInfo.Name);
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (app != null)
                    app.Quit();

            }
            return false;
        }

    }
}
