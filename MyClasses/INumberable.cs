using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObjects {
    public interface INumberable<T> {
        T GetFavoriteNumber();
        string SayFavorite(T value);
    }
}
