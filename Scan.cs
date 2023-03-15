using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDB4Scanner {
    public class Scan {
        // everything inside 1 scan
        private int _totalDetected = 0; // total detected issues

        // according to the scan itself:
        private string _gameVer = "Fallout 4 v1.10.163"; // game version
        private string _gameVerVR = "Fallout 4 v1.2.72"; // game VR version
        private string _buffVer = "Buffout 4 v1.26.2"; // latest buff version
        private string _buffVerVR = "Buffout 4 v1.29.0 Nov  5 2022 02:22:25"; // buff VR version
        private string _mainException; // main exception
        
        // COMPATIBILITY
        private bool _compatF4EE; // F4EE (LooksMenu) Compatibility

        // FIXES
        private bool _actorHostileToActor; // Actor is hostile to actor
        private bool _cellInit; // cell init
        private bool _createD3D; // create D3D and swap chain
        private bool _encounterZoneReset; // encounter zone reset
        private bool _greyMovies; // Grey Movies
        private bool _mgefApplyEvent; // Magic Effect Apply Event
        private bool _movementPlanner; // Movement Planner
        private bool _pkgAllocateLocation; // package allocate location
        private bool _safeExit; // safe exit
        private bool _tesObjREFRGetEncZone; // TES Object REFR Get Encounter Zone
        private bool _unalignedLoad; // unaligned load
        private bool _utilShader; // utility shader

        // PATCHES
        private bool _achievements; // Achievements
        private bool _managerBSMTA; // BSMTA Manager
        private bool _bsPreCulledObjects; // BS Pre Culled Objects
        private bool _bsTextureStreamerLocalHeap; // BS texture streamer local heap
        private bool _havokMemSys; // Havok Memory System
        private bool _iniSettingCollection; // INI Setting Collection
        private bool _inputSwitch; // input switch
        private int _maxStdIO = 0; // !!! Can be negative !!!
        private bool _memManager; // memory manager
        private bool _memManagerDebug; // memory manager debug
        private bool _scaleformAlloc; // scale form allocator
        private bool _smallBlockAlloc; // small block allocator
        private bool _workshopMenu; // workshop menu

        // WARNINGS
        private bool _create2DTexture;
        private bool _imageSpaceAdapter;

        // SYSTEM SPECS
        private string _operatingSystem;
        private string _cpu;
        private string _gpu1; // gtx 1060
        private string _gpu2; // ms basic render driver
        private string _mem; // USED/TOTAL (ex.: 11.98 GB/15.96 GB)

        // PLUGINS
        private List<string> Plugins = new List<string>();

        // KNOWN ISSUES (Collective Modding)
        // hmmm....

        // ############################################################

        // Constructor:
        // hmmm....

        // Get-Set
        // known (found) issues:
        

        // compatibility, fixes, patches, warnings, system (from buffout's crash log):
        public int TotalDetected {
            get { return _totalDetected; }
            set { _totalDetected = value; }
        }

        public string MainException {
            get { return _mainException; }
            set { _mainException = value; }
        }

        public bool CompatibilityF4EE {
            get { return _compatF4EE; }
            set { _compatF4EE = value; }
        }

        public bool ActorIsHostileToActor {
            get { return _actorHostileToActor; }
            set { _actorHostileToActor = value; }
        }

        public bool CellInit {
            get { return _cellInit; }
            set { _cellInit = value; }
        }

        public bool CreateD3DAndSwapChain {
            get { return _createD3D; }
            set { _createD3D = value; }
        }

        public bool EncounterZoneReset {
            get { return _encounterZoneReset; }
            set { _encounterZoneReset = value; }
        }

        public bool GreyMovies {
            get { return _greyMovies; }
            set { _greyMovies = value; }
        }

        public bool MagicEffectApplyEvent {
            get { return _mgefApplyEvent; }
            set { _mgefApplyEvent = value; }
        }

        public bool MovementPlanner {
            get { return _movementPlanner; }
            set { _movementPlanner = value; }
        }

        public bool PackageAllocateLocation {
            get { return _pkgAllocateLocation; }
            set { _pkgAllocateLocation = value; }
        }

        public bool SafeExit {
            get { return _safeExit; }
            set { _safeExit = value; }
        }

        public bool TESObjectREFRGetEncounterZone {
            get { return _tesObjREFRGetEncZone; }
            set { _tesObjREFRGetEncZone = value; }
        }

        public bool UnalignedLoad {
            get { return _unalignedLoad; }
            set { _unalignedLoad = value; }
        }

        public bool UtilityShader {
            get { return _utilShader; }
            set { _utilShader = value; }
        }

        public bool Achievements {
            get { return _achievements; }
            set { _achievements = value; }
        }

        public bool BSMTAmanager {
            get { return _managerBSMTA; }
            set { _managerBSMTA = value; }
        }

        public bool BSPreCulledObjects {
            get { return _bsPreCulledObjects; }
            set { _bsPreCulledObjects = value; }
        }

        public bool BSTextureStreamerLocalHeap {
            get { return _bsTextureStreamerLocalHeap; }
            set { _bsTextureStreamerLocalHeap = value; }
        }

        public bool HavokMemorySystem {
            get { return _havokMemSys; }
            set { _havokMemSys = value; }
        }

        public bool INISettingCollection {
            get { return _iniSettingCollection; }
            set { _iniSettingCollection = value; }
        }

        public bool InputSwitch {
            get { return _inputSwitch; }
            set { _inputSwitch = value; }
        }

        public int MaxStdIO {
            get { return _maxStdIO; }
            set { _maxStdIO = value; }
        }

        public bool MemoryManager {
            get { return _memManager; }
            set { _memManager = value; }
        }

        public bool MemoryManagerDebug {
            get { return _memManagerDebug; }
            set { _memManagerDebug = value; }
        }

        public bool ScaleformAllocator {
            get { return _scaleformAlloc; }
            set { _scaleformAlloc = value; }
        }

        public bool SmallBlockAllocator {
            get { return _smallBlockAlloc; }
            set { _smallBlockAlloc = value; }
        }

        public bool WorkshopMenu {
            get { return _workshopMenu; }
            set { _workshopMenu = value; }
        }

        public bool CreateTexture2D {
            get { return _create2DTexture; }
            set { _create2DTexture = value; }
        }

        public bool ImageSpaceAdapter {
            get { return _imageSpaceAdapter; }
            set { _imageSpaceAdapter = value; }
        }

        public string OperatingSystem {
            get { return _operatingSystem; }
            set { _operatingSystem = value; }
        }

        public string Processor {
            get { return _cpu;  }
            set { _cpu = value; }
        }

        public string Graphics1 {
            get { return _gpu1; }
            set { _gpu1 = value; }
        }

        public string Graphics2 {
            get { return _gpu2; }
            set { _gpu2 = value; }
        }

        public string Memory {
            get { return _mem; }
            set { _mem = value; }
        }
    }
}
