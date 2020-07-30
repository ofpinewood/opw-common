namespace Opw.Entities
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
