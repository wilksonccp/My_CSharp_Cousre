using System.Data.Common;


namespace GPTHotel;

public class Reservation
{
    public string Gest { get; set; }
    public int Room { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public Reservation()
    {
    }   
    public Reservation(string gest, int room, DateTime checkIn, DateTime checkOut)
    {
        Gest = gest;
        if (room < 1 || room > 100)
        {
            throw new DomainException("O número do quarto deve estar entre 1 e 100.");
        }
        Room = room;
        if (checkOut <= checkIn)
        {
            throw new DomainException("A data de check-out deve ser após a data de check-in.");
        }
        CheckIn = checkIn;
        CheckOut = checkOut;
    }
    
    override public string ToString()
    {
        return $"Reserva confirmada! {Gest}, Quarto: {Room}, CheckIn: {CheckIn.ToString("dd/MM/yyyy")}, CheckOut: {CheckOut.ToString("dd/MM/yyyy")}";
    }

}
