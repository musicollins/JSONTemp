using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSON.UI.DataAccess.Mapper
{
    public interface EntityMapper<TIn, TOut>
    {
        TOut Mapper(TIn Dto);
    }

}
