namespace MAS3;

public class LibraryItem
{
    private Material material;

    public LibraryItem(Material material)
    {
        this.material = material;
    }

    public void Borrow()
    {
        if (material is IBorrowable borrowable){
            borrowable.Borrow();
        }
    }
    public void Return()
    {
        if (material is IBorrowable borrowable){
            borrowable.Return();
        }
    }

    public void Reserve()
    {
        if (material is IReservable reservable) {
            reservable.Reserve();
        }
    }
}