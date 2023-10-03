// See https://aka.ms/new-console-template for more information
using Inheritance.Entities;

Console.WriteLine("Calendar App");

Meeting meeting1 = new()
{

    Title = "Yetgen Jump & Akbank Backend Planlama Toplantısı",
    Details = new List<string>()
    { "Katılımcıların alım süreçleri konuşulacak, ",
    "bütçe planlaması konuşulacak"
    },
    StartTime = new DateTime(2023, 09, 18, 19, 00, 00),
    FinishTime = new DateTime(2023, 09, 18, 20, 00, 00),
    Guests = new() { "iremdemir@deneme.com", "eren@deneme.com" },
};

Todo todo1 = new()
{
    Title = "Katılımcı geri bildirimleri teslim et",
    Details = new List<string>()
    {
        "Değerlendirme sonuçlarının anonimlendirilmesi"
    },
    StartTime = new DateTime(2023, 09, 20, 19, 00, 00),
    FinishTime = new DateTime(2023, 09, 20, 20, 00, 00),
    Importance = ""
};


meeting1.GetNotification();

todo1.GetNotification();
