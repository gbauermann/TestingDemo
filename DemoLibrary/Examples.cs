using System;

namespace DemoLibrary
{
    public static class Examples
    {
        public static string ExampleLoadTextFile(string file)
        {
            if (file.Length < 10)
                throw new ArgumentException("Nome do arquivo é muito curto", "file");

            return "Arquivo carregado com sucesso";
        }
    }
}
