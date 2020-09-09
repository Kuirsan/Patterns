using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class CeilinfFanOffCommand:ICommand
    {
        private CeilingFan _ceilinfFan;
        private int _prevspeed;

        public CeilinfFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilinfFan = ceilingFan;
        }
        public void execute()
        {
            _prevspeed = _ceilinfFan.getSpeed();
            _ceilinfFan.off();
        }

        public void undo()
        {
            if (_prevspeed == CeilingFan.HIGH)
            {
                _ceilinfFan.high();
            }
            else if (_prevspeed == CeilingFan.MEDIUM)
            {
                _ceilinfFan.medium();
            }
            else if (_prevspeed == CeilingFan.LOW)
            {
                _ceilinfFan.low();
            }
            else if (_prevspeed == CeilingFan.OFF)
            {
                _ceilinfFan.off();
            }
        }
    }
}
