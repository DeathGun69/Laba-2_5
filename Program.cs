using System;
using System.IO;

namespace laba2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ADMIN\Documents\sergey\KPO\laba2_5\text.txt";
            string line;
            string[] words_mass;
            int count_num = 0;
            int max_num = 0;

            if(File.Exists(path)){
                StreamReader stread = new StreamReader(path, System.Text.Encoding.Default);
                
                try {
                    Console.WriteLine("\nФайл: {0}", Path.GetFileName(path));
                    Console.WriteLine();

                    using (stread){
                        while ((line = stread.ReadLine()) != null)
                        {
                            words_mass = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            Console.WriteLine($"\nТекущая строка: {line}");

                            foreach(var mass in words_mass) {
                                int n = mass.Length;
                                char[] w_char = mass.ToCharArray();
                                for(int i=0; i<n; i++){
                                    switch(w_char[i]){
                                        case '0': count_num++;
                                            break;
                                        case '1': count_num++;
                                            break;
                                        case '2': count_num++;
                                            break;
                                        case '3': count_num++;
                                            break;
                                        case '4': count_num++;
                                            break;
                                        case '5': count_num++;
                                            break;
                                        case '6': count_num++;
                                            break;
                                        case '7': count_num++;
                                            break;
                                        case '8': count_num++;
                                            break;
                                        case '9': count_num++;
                                            break;        
                                        }
                                    }
                                    if (count_num > max_num)
                                        max_num = count_num;
                                        count_num = 0;
                                }
                                Console.WriteLine("Наибольшее число цифр: {0}", max_num);
                                max_num = 0;
                            }
                        }
                    } catch (Exception e) {
                        Console.WriteLine(e.Message);
                    } finally {
                        try {
                            stread.Close();
                        } catch (Exception e) {
                            Console.WriteLine(e.Message);
                        }
                    }
            } else {
                Console.WriteLine("Файла {0} не существует.", Path.GetFileName(path));
            }    
        }
    }
}
