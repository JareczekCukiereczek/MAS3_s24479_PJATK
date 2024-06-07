


namespace MAS3

{
    public class Program
    {
        public static void Main(string[] args)
        {
            var library = new Library();

            var book = new Book
            ("C# jest kochany ale nie masy", "Jakub Jaros", 2020, 500, "123456789");
            var magazine = new Magazine
            ("SpajderMen", "Karaluch", 2021, 5, "May");

            var dvd = new DVD
            (5, "Producer C", "Pietrek Kogucik - historia prawdziwa", "Pietrek Kogucik", 2024);

            library.AddMaterial(book);
            library.AddMaterial(magazine);
            library.AddMaterial(dvd);
            Console.WriteLine("Polimorfizm1");
            Console.WriteLine("_________________________________________________________");
            book.getTypeOfMaterial();
            dvd.getTypeOfMaterial();
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine("Polimorfizm2");
            Console.WriteLine("_________________________________________________________");
            book.Borrow();//ta sama metod co innego sie dzieje
            magazine.Borrow();
            Console.WriteLine("_________________________________________________________");
            var libraryItemBook = new LibraryItem(book);
            libraryItemBook.Borrow();
            libraryItemBook.Reserve();
            libraryItemBook.Return();
            Console.WriteLine("overlapping");
            Console.WriteLine("_________________________________________________________");
            //overlapping
            dvd.addDVDType(DVDenum.BluRay);
            dvd.playHighResulionVideo();
            Console.WriteLine("_________________________________________________________");
            dvd.addDVDType(DVDenum.Kaseta);
            dvd.playTurboLowResulitonVideo();
            
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine("Wielodziedziczenie");
            book.Borrow();
            book.Reserve();
            Console.WriteLine(book.Title);
            Console.WriteLine("_________________________________________________________");
        }
    }
}

/*
-Klasa abstrakcyjna + polifimorfizm
Material jest klasą abstrakcyjną, która definiuje wspólne właściwości dla wszystkich materiałów bibliotecznych Title, Author, Year.

Klasy Book, Magazine i DVD dziedziczą po klasie Material i implementują interfejsy IBorrowable i IReservable. Umożliwia to różnym typom
materiałów biblitoeki posiadanie własnych implementacji metod Borrow, eturn i Reserve, co pozwala na dynamiczne wywoływanie odpowiednich metod 
w czasie działania programu + tak samo z metodą getTypeOfMaterial tez pokazanie polifmorizmu
-Overlapping - spłaszczenie hierarchii
dodanie enum  - w kazdej metodzie odpowiadajace podklasie sprawdzamy w podliscie czy jest dodana podwariant.
DVDenum - dyskryminator (specjalny atrybut)

-Wielodziedziczenie  zrealizowane przez dziedziczenie wielu interfejsów
Klasy Book, Magazine i DVD implementują interfejsy IBorrowable oraz, w przypadku Book, również IReservable. Pokazujemy wielodziedziczenie przez
implementację wielu interfejsów w klasie book.
 */