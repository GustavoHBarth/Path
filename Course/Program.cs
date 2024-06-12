namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";

            //Mostrar o caracter de separação
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            //Mostrar caracter usado para separar entre Patch diferentes
            Console.WriteLine("PathSeparator" + Path.PathSeparator);
            //Pega somente as pastas
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            //Pegar o noem do arquivo
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            //Mostrar nome sem extenção
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            //Mostrar somente extenção do arquivo
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            //Pegar todo caminho do arquivo
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            //Mostrar qual é a pasta do sistema que é possivel manipular dados de aplicações
            Console.WriteLine("GetTempPath" + Path.GetTempPath());
        }
    }
}
