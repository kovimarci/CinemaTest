namespace CinemaApp
{
    public class Screening
    {
        private readonly string _title;
        private readonly int _totalSeats;
        private readonly List<string> _bookedNames;

        // title nem lehet null vagy üres, totalSeats >= 1
        public Screening(string title, int totalSeats)
        {
            if (title != null && title.Trim() != "" && totalSeats > 0)
            {
                _title = title.Trim();
                _totalSeats = totalSeats;
                _bookedNames = [];
            } else throw new ArgumentException();
        }

        public string GetTitle()
        {
            return _title;
        }

        // Visszatér false ha nincs szabad hely, vagy a személy már foglalt
        public bool BookSeat(string name)
        {
            if (_bookedNames.Count < _totalSeats)
            {
                _bookedNames.Add(name.Trim());
                return true;
            }
            return false;
        }

        // Visszatér false ha a személy neve nem szerepel a _bookedNames listában
        public bool CancelBooking(string name)
        {
            if (_bookedNames.Contains(name.Trim()))
            {
                _bookedNames.Remove(name.Trim());
                return true;
            }
            return false;
        }

        public bool IsBooked(string name)
        {
            if (_bookedNames.Contains(name.Trim())) return true;
            return false;
        }

        // Szabad helyek = _totalSeats - _bookedNames.Count
        public int GetAvailableSeats()
        {
            return _totalSeats - _bookedNames.Count;
        }

        public int GetBookedCount()
        {
            return _bookedNames.Count;
        }

        public bool IsHouseFull()
        {
            if (_bookedNames.Count == _totalSeats)
                return true;
            return false;
        }

        // -------------------------------------------------------
        // EXTRA FELADAT — Várólista
        // Az alábbi mezőt és metódusokat csak akkor vedd fel,
        // ha az alap feladattal már végzett vagy!
        // -------------------------------------------------------

        // private readonly List<string> _waitingList;

        // public bool AddToWaitingList(string name)
        // {
        //     throw new NotImplementedException();
        // }

        // public bool RemoveFromWaitingList(string name)
        // {
        //     throw new NotImplementedException();
        // }

        // public bool IsOnWaitingList(string name)
        // {
        //     throw new NotImplementedException();
        // }

        // public int GetWaitingListCount()
        // {
        //     throw new NotImplementedException();
        // }

        // public int GetWaitingPosition(string name)
        // {
        //     throw new NotImplementedException();
        // }
    }
}
