namespace JSON.UI.DataAccess.Mapper
{
    public interface EntityMapper<TIn, TOut>
    {
        TOut Mapper(TIn Dto);
    }

}
