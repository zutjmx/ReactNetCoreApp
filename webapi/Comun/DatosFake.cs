namespace webapi.Comun
{
    public class DatosFake
    {
        public DatosFake()
        {
                
        }

        public string GeneraCadenaLorem(int cantidad)
        {
            string cadenaLorem;

            if(cantidad <= 0)
            {
                cadenaLorem = Faker.Lorem.Paragraph();
            } else
            {
                cadenaLorem = Faker.Lorem.Paragraph(cantidad);
            }

            return cadenaLorem;
        }

        public string[] GeneraArrCadenaLorem()
        {
            string[] cadenaLorem = new string[10];
            for (int i = 0; i < cadenaLorem.Length; i++)
            {
                cadenaLorem[i] = Faker.Lorem.Paragraph();
            }
            return cadenaLorem;
        }
    }
}
