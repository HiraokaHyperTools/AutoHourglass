using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace kenjiuno.AutoHourglass
{
    public class AH : IDisposable
    {
        Cursor previous;

        public AH()
        {
            previous = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
        }

        public void Dispose()
        {
            Cursor.Current = previous ?? Cursor.Current;
            previous = null;
        }
    }
}
