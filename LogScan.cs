using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDB4Scanner {
    public class LogScan {
        // variables:
        private List<string> _scanResults = new List<string>();
        private int _numDetected = 0; // total detected
        
        // versions:
        private string _gameVer = "Fallout 4 v1.10.163";
        private string _gameVerVR = "Fallout 4 v1.2.72";
        private string _buffVer = "Buffout 4 v1.26.2";
        private string _buffVerVR = "Buffout 4 v1.29.0 Nov  5 2022 02:22:25";
        // detected versions:
        private string _latestGame;
        private string _latestGameVR;
        private string _latestBuff;
        private string _latestBuffVR;

        public List<string> ScanLogFile(string logPath) {
            // #0 check if the provided .log is valid Buffout 4 log:
            // #1 check game and Buffout version; check if there's newer Buffout version available:

            using (StreamReader reader = new StreamReader(logPath)) {
                string detectedGameVer = reader.ReadLine();
                string detectedBuffVer = reader.ReadLine();

                if ((detectedGameVer != _gameVer) && (detectedGameVer != _gameVerVR)) {
                    //_scanResults.Add("(Outdated Game!)");
                    _scanResults.Add(detectedGameVer + " - Old");
                    NumDetected++;
                } else {
                    _scanResults.Add(detectedGameVer);
                }

                if ((detectedBuffVer != _buffVer) && (detectedBuffVer != _buffVerVR)) {
                    _scanResults.Add("(Outdated Buffout4!)");
                    NumDetected++;
                } else {
                    _scanResults.Add(detectedBuffVer.ToString());
                }
            }

                // #####


                // return results
                return _scanResults;
        }

        public string GameVer {
            get { return _gameVer; }
            set { _gameVer = value; }
        }

        public string GameVerVR {
            get { return _gameVerVR; }
            set { _gameVerVR = value; }
        }

        public string BuffVer {
            get { return _latestBuff; }
            set { _latestBuff = value; }
        }

        public string BuffVerVR {
            get { return _latestBuffVR; }
            set { _latestBuffVR = value; }
        }

        // total number of detected (possible):
        public int NumDetected {
            get { return _numDetected; }
            set { _numDetected = value; }
        }
    }
}
