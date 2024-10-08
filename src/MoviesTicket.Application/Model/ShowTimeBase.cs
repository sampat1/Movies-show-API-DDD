namespace MoviesTicket.Application.Model
{
    public record MovieShowTimeBase
    {
        public required string Time { get; set; }
    }
    public record MovieShowTimeGUIDBase:MovieShowTimeBase
    {
        public required Guid MovieShowTimeGUID { get; set; }
    }
    public record MovieShowBase
    {
        public required DateTime ShowDate { get; set; }

    }
   
    public record CreateMovieShowTime : MovieShowBase
    {
        public IEnumerable<MovieShowTimeBase> MovieShowTimes { get; set; }
    }
    public record UpdateMovieShowTime : MovieShowBase
    {
        public IEnumerable<MovieShowTimeGUIDBase> MovieShowTimes { get; set; }
    }
    public record ShowBooked
    {
        public Guid MovieShowGUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
    public record GetMovieShow : MovieShowBase
    {
        public IEnumerable<MovieShowTimeGUIDBase> MovieShowTimes { get; set; }

    }
}