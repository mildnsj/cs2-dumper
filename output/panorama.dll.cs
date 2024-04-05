// Generated using https://github.com/a2x/cs2-dumper
// 2024-04-05 17:13:47.447480800 UTC

namespace CS2Dumper.Schemas {
    // Module: panorama.dll
    // Classes count: 0
    // Enums count: 2
    public static class PanoramaDll {
        // Alignment: 4
        // Members count: 13
        public enum ELayoutNodeType : uint {
            ROOT = 0x0,
            STYLES = 0x1,
            SCRIPT_BODY = 0x2,
            SCRIPTS = 0x3,
            SNIPPETS = 0x4,
            INCLUDE = 0x5,
            SNIPPET = 0x6,
            PANEL = 0x7,
            PANEL_ATTRIBUTE = 0x8,
            PANEL_ATTRIBUTE_VALUE = 0x9,
            REFERENCE_CONTENT = 0xA,
            REFERENCE_COMPILED = 0xB,
            REFERENCE_PASSTHROUGH = 0xC
        }
        // Alignment: 4
        // Members count: 15
        public enum EStyleNodeType : uint {
            ROOT = 0x0,
            EXPRESSION = 0x1,
            PROPERTY = 0x2,
            DEFINE = 0x3,
            IMPORT = 0x4,
            KEYFRAMES = 0x5,
            KEYFRAME_SELECTOR = 0x6,
            STYLE_SELECTOR = 0x7,
            WHITESPACE = 0x8,
            EXPRESSION_TEXT = 0x9,
            EXPRESSION_URL = 0xA,
            EXPRESSION_CONCAT = 0xB,
            REFERENCE_CONTENT = 0xC,
            REFERENCE_COMPILED = 0xD,
            REFERENCE_PASSTHROUGH = 0xE
        }
    }
}
