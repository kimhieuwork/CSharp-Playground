// See https://aka.ms/new-console-template for more information
string[] nhungConGa = { "Bui Xuan Ba'nh", "Nguyen Kim Hieu'", "Nguyen Ngoc Trinh", "Luong Tien Dat", "Nguyen The Dung", "Do Thanh Lam"};
bool check = false;
int choice;

do
{
    Console.WriteLine("Pick one:");
    Console.WriteLine("1 - 6");
    Console.WriteLine("Or pick anykey to exit");
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine(nhungConGa[0]);
            break;
        case 2:
            Console.WriteLine(nhungConGa[1]);
            break;
        case 3:
            Console.WriteLine(nhungConGa[2]);
            break;
        case 4:
            Console.WriteLine(nhungConGa[3]);
            break;
        case 5:
            Console.WriteLine(nhungConGa[4]);
            break;
        case 6:
            Console.WriteLine(nhungConGa[5]);
            break;
        default:
            Console.WriteLine("Dung bao gio coi thuong nguoi khac!");
            check = true;
            break;

    }

} while(check==false);