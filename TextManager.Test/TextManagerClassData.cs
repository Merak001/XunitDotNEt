using System.Collections;

namespace TextManagerTest;
                                    
public class TextManagerClassData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { "asdsad", 1};
        yield return new object[] { "Hola munndo", 1 };
        yield return new object[] { "Esta es una prueba", 1};
    }
    IEnumerator IEnumerable.GetEnumerator(){
        return GetEnumerator();
    }

}