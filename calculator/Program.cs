namespace assignmentone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 гэж бичиж программыг эхлүүлнэ үү");
            int Start = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("1 гэж бичиж программыг эхлүүлэх болон дахин эхлэх боломжтой харин -1 гэж бичиж программаас гарна.");
                int firstNum;
                int secNum;
                int sum;
                char sign;
                Console.WriteLine("Хийх үйлдэлээ сонгоно уу (+,-,*,/)");
                sign = char.Parse(Console.ReadLine());
                
                if (sign == '+')
                {
                    Console.WriteLine("Эхний нэмэх тоогоо оруулна уу");
                    firstNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Дараагийн нэмэх тоогоо оруулна уу");
                    secNum = int.Parse(Console.ReadLine());
                    sum = firstNum + secNum;
                    Console.WriteLine("Үр дүн: {0} + {1} = {2}", firstNum, secNum, sum);
                }
                
                if (sign == '-')
                {
                    Console.WriteLine("Эхний тоогоо оруулна уу");
                    firstNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Дараагийн хасах тоогоо оруулна уу");
                    secNum = int.Parse(Console.ReadLine());
                    sum = firstNum - secNum;
                    Console.WriteLine("Үр дүн: {0} - {1} = {2}", firstNum, secNum, sum);
                }
                
                if (sign == '*')
                {
                    Console.WriteLine("Эхний үржих тоогоо оруулна уу");
                    firstNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Дараагийн үржих тоогоо оруулна уу");
                    secNum = int.Parse(Console.ReadLine());
                    sum = firstNum * secNum;
                    Console.WriteLine("Үр дүн: {0} * {1} = {2}", firstNum, secNum, sum);
                }
                
                if (sign == '/')
                {
                    Console.WriteLine("Хуваах тоогоо оруулна уу");
                    firstNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Хэдэд хуваах тоогоо оруулна уу");
                    secNum = int.Parse(Console.ReadLine());
                    sum = firstNum / secNum;
                    Console.WriteLine("Үр дүн: {0} / {1} = {2}", firstNum, secNum, sum);
                }

            } while (Start == 1);
        }
    }
}