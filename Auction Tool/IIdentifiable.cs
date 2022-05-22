namespace Auction_Tool {
    /*
     * RO: Pentru clase cu câmpuri ID-uri unice
     * EN: For classes that use an ID field
     */
    public interface IIdentifiable {
        int Id { get; set; }
    }
}
