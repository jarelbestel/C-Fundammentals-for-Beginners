namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 5;
            int y = 10;
            int z = (x + 1 + y);
            Console.WriteLine(z);
            Console.ReadLine();
            */

            Console.WriteLine("Kapı açma oyununa hoşgeldiniz");
            apoLLon:
            Console.Write("Lütfen açacağınız kapıyı seçiniz [1] [2] [3] ? : ");//Kapı numarasını sordum
            string uSerValue = Console.ReadLine();//string tanımı (uServalue) konsol tarafından okunmasını istedim.
            string mEssage = "";//  verilecek mesajların atandığı string.

            if (uSerValue == "1" || uSerValue == "2" || uSerValue == "3")// kullanıcı rakamdan başka bir şey girmesin diye yazdım
            {
                Console.WriteLine("-----------------------------");
                Console.Write($"{uSerValue} numaralı kapıyı seçtiniz onaylar mısınız? :");//konsol kapı onayı soruyor burada
                Console.ReadLine();//bu komutla girilen evet/hayır değerini okuyor
                string aNswer = "";//evet hayır değişkeninin atandığı string

                if (uSerValue == "1" || aNswer == "evet")//sorgulama durumu 1
                {
                    mEssage = "Kedi buldunuz";
                }

                else if (uSerValue == "2" || aNswer == "evet")//sorgulama durumu 2
                {
                    {
                    mEssage = "Fare buldunuz";
                }

                else if (uSerValue == "3" || aNswer == "evet")//sorgulama durumu 3
                    {
                        {
                    mEssage = "Fotoğraf buldunuz";
                }

                else//başarısızlık durumuunda verilecek mesajın kodu.
                {
                    mEssage = "Üzgünüm, seçiminizi anlaşılmadı !";
                    mEssage += " Kaybettiniz";//mEssage değerinin += butonuyla kullanım yöntemi, bu yöntem güzel

                }

                    Console.WriteLine(mEssage);
                    Console.ReadLine();
            }

            else 
            {
                Console.WriteLine("Lütfen rakam tercih ediniz!");
                goto apoLLon;
            }
           
        }
    }
}

