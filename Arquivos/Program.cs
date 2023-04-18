namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\thiago.bueno\Documents\Projetos\Estudos\Arquivos\myFolder\file1.txt";
            //string targetPath = @"C:\Users\thiago.bueno\Documents\Projetos\Estudos\Arquivos\file2.txt";

            StreamReader sr = null;

            try
            {
                #region File e FileInfo
                //FileInfo fileInfo = new FileInfo(sourcePath);
                ////fileInfo.CopyTo(targetPath);

                //string[] files = File.ReadAllLines(sourcePath);
                //foreach(var file in files)
                //{
                //    Console.WriteLine(file);
                //}
                #endregion

                #region FileStream e StreamReader
                //sr = File.OpenText(sourcePath);
                //while(!sr.EndOfStream)
                //{
                //    string line = sr.ReadLine();
                //    Console.WriteLine(line);
                //}
                #endregion

                #region using
                //using (sr = File.OpenText(sourcePath))
                //{
                //    while (!sr.EndOfStream)
                //    {
                //        string line = sr.ReadLine();
                //        Console.WriteLine(line);
                //    }
                //}
                #endregion

                #region StreamWriter
                //string[] lines = File.ReadAllLines(sourcePath);
                //using(StreamWriter sw = File.AppendText(targetPath))
                //{
                //    foreach(string line in lines)
                //    {
                //        sw.WriteLine(line.ToUpper());
                //    }
                //}
                #endregion

                #region Directory e DirectoryInfo
                //Lista as subpastas dentro da pasta informada
                //IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                //Console.WriteLine("FOLDERS:");
                //foreach (string s in folders)
                //{
                //    Console.WriteLine(s);
                //}

                ////Lista os arquivos dentro da pasta informada
                //IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                //Console.WriteLine("FILES:");
                //foreach (string s in files)
                //{
                //    Console.WriteLine(s);
                //}

                ////Criar uma nova pasta
                //Directory.CreateDirectory(path + "\\newFolder"); // ou usar @"\newFolder"
                #endregion

                #region Path
                //Retorna somente porção do caminho informado
                Console.WriteLine(Path.GetDirectoryName(path));

                //Retorna o caracter de separação do arquivo, no caso a \
                Console.WriteLine(Path.DirectorySeparatorChar);

                //Retorna o caracter de separação do arquivo, no caso a ;
                Console.WriteLine(Path.PathSeparator);

                //Retorna o nome do arquivo
                Console.WriteLine(Path.GetFileName(path));

                //Retorna o nome do arquivo sem a extensão no nome
                Console.WriteLine(Path.GetFileNameWithoutExtension(path));

                //Retorna o nome da extensão do arquivo
                Console.WriteLine(Path.GetExtension(path));

                //Retorna o caminho completo do arquivo
                Console.WriteLine(Path.GetFullPath(path));

                //Retorna a pasta temporaria do sistema
                Console.WriteLine(Path.GetTempPath());
                #endregion
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
