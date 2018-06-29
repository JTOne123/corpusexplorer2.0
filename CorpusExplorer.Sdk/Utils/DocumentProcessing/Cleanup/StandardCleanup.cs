﻿using CorpusExplorer.Sdk.Properties;

#region

using System.Collections.Generic;
using System.Linq;
using CorpusExplorer.Sdk.Utils.DocumentProcessing.Cleanup.Abstract;

#endregion

namespace CorpusExplorer.Sdk.Utils.DocumentProcessing.Cleanup
{
  public class StandardCleanup : AbstractCleanup
  {
    private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>
    {
      {"&quot;", "\""},
      {"&amp;", "&"},
      {"&lt;", "<"},
      {"&gt;", ">"},
      {"&apos;", "'"},
      {"&nbsp;", " "},
      {"&iexcl;", "¡"},
      {"&cent;", "¢"},
      {"&pound;", "£"},
      {"&curren;", "¤"},
      {"&yen;", "¥"},
      {"&brvbar;", "¦"},
      {"&sect;", "§"},
      {"&uml;", "¨"},
      {"&copy;", "©"},
      {"&ordf;", "ª"},
      {"&laquo;", "\""},
      {"&not;", "¬"},
      {"&shy;", " "},
      {"&reg;", "®"},
      {"&macr;", "¯"},
      {"&deg;", "°"},
      {"&plusmn;", "±"},
      {"&sup2;", "²"},
      {"&sup3;", "³"},
      {"&acute;", "´"},
      {"&micro;", "µ"},
      {"&para;", "¶"},
      {"&middot;", "·"},
      {"&cedil;", "¸"},
      {"&sup1;", "¹"},
      {"&ordm;", "º"},
      {"&raquo;", "\""},
      {"&frac14;", "¼"},
      {"&frac12;", "½"},
      {"&frac34;", "¾"},
      {"&iquest;", "¿"},
      {"&Agrave;", "À"},
      {"&Aacute;", "Á"},
      {"&Acirc;", "Â"},
      {"&Atilde;", "Ã"},
      {"&Auml;", "Ä"},
      {"&Aring;", "Å"},
      {"&AElig;", "Æ"},
      {"&Ccedil;", "Ç"},
      {"&Egrave;", "È"},
      {"&Eacute;", "É"},
      {"&Ecirc;", "Ê"},
      {"&Euml;", "Ë"},
      {"&Igrave;", "Ì"},
      {"&Iacute;", "Í"},
      {"&Icirc;", "Î"},
      {"&Iuml;", "Ï"},
      {"&ETH;", "Ð"},
      {"&Ntilde;", "Ñ"},
      {"&Ograve;", "Ò"},
      {"&Oacute;", "Ó"},
      {"&Ocirc;", "Ô"},
      {"&Otilde;", "Õ"},
      {"&Ouml;", "Ö"},
      {"&times;", "×"},
      {"&Oslash;", "Ø"},
      {"&Ugrave;", "Ù"},
      {"&Uacute;", "Ú"},
      {"&Ucirc;", "Û"},
      {"&Uuml;", "Ü"},
      {"&Yacute;", "Ý"},
      {"&THORN;", "Þ"},
      {"&szlig;", "ß"},
      {"&agrave;", "à"},
      {"&aacute;", "á"},
      {"&acirc;", "â"},
      {"&atilde;", "ã"},
      {"&auml;", "ä"},
      {"&aring;", "å"},
      {"&aelig;", "æ"},
      {"&ccedil;", "ç"},
      {"&egrave;", "è"},
      {"&eacute;", "é"},
      {"&ecirc;", "ê"},
      {"&euml;", "ë"},
      {"&igrave;", "ì"},
      {"&iacute;", "í"},
      {"&icirc;", "î"},
      {"&iuml;", "ï"},
      {"&eth;", "ð"},
      {"&ntilde;", "ñ"},
      {"&ograve;", "ò"},
      {"&oacute;", "ó"},
      {"&ocirc;", "ô"},
      {"&otilde;", "õ"},
      {"&ouml;", "ö"},
      {"&divide;", "÷"},
      {"&oslash;", "ø"},
      {"&ugrave;", "ù"},
      {"&uacute;", "ú"},
      {"&ucirc;", "û"},
      {"&uuml;", "ü"},
      {"&yacute;", "ý"},
      {"&thorn;", "þ"},
      {"&yuml;", "ÿ"},
      {"&OElig;", "Œ"},
      {"&oelig;", "œ"},
      {"&Scaron;", "Š"},
      {"&scaron;", "š"},
      {"&Yuml;", "Ÿ"},
      {"&fnof;", "ƒ"},
      {"&circ;", "ˆ"},
      {"&tilde;", "˜"},
      {"&Alpha;", "Α"},
      {"&alpha;", "α"},
      {"&Beta;", "Β"},
      {"&beta;", "β"},
      {"&Gamma;", "Γ"},
      {"&gamma;", "γ"},
      {"&Delta;", "Δ"},
      {"&delta;", "δ"},
      {"&Epsilon;", "Ε"},
      {"&epsilon;", "ε"},
      {"&Zeta;", "Ζ"},
      {"&zeta;", "ζ"},
      {"&Eta;", "Η"},
      {"&eta;", "η"},
      {"&Theta;", "Θ"},
      {"&theta;", "θ"},
      {"&Iota;", "Ι"},
      {"&iota;", "ι"},
      {"&Kappa;", "Κ"},
      {"&kappa;", "κ"},
      {"&Lambda;", "Λ"},
      {"&lambda;", "λ"},
      {"&Mu;", "Μ"},
      {"&mu;", "μ"},
      {"&Nu;", "Ν"},
      {"&nu;", "ν"},
      {"&Xi;", "Ξ"},
      {"&xi;", "ξ"},
      {"&Omicron;", "Ο"},
      {"&omicron;", "ο"},
      {"&Pi;", "Π"},
      {"&pi;", "π"},
      {"&Rho;", "Ρ"},
      {"&rho;", "ρ"},
      {"&Sigma;", "Σ"},
      {"&sigmaf;", "ς"},
      {"&sigma;", "σ"},
      {"&Tau;", "Τ"},
      {"&tau;", "τ"},
      {"&Upsilon;", "Υ"},
      {"&upsilon;", "υ"},
      {"&Phi;", "Φ"},
      {"&phi;", "φ"},
      {"&Chi;", "Χ"},
      {"&chi;", "χ"},
      {"&Psi;", "Ψ"},
      {"&psi;", "ψ"},
      {"&Omega;", "Ω"},
      {"&omega;", "ω"},
      {"&thetasym;", "ϑ"},
      {"&upsih;", "ϒ"},
      {"&piv;", "ϖ"},
      {"&forall;", "∀"},
      {"&part;", "∂"},
      {"&exist;", "∃"},
      {"&empty;", "∅"},
      {"&nabla;", "∇"},
      {"&isin;", "∈"},
      {"&notin;", "∉"},
      {"&ni;", "∋"},
      {"&prod;", "∏"},
      {"&sum;", "∑"},
      {"&minus;", "−"},
      {"&lowast;", "∗"},
      {"&radic;", "√"},
      {"&prop;", "∝"},
      {"&infin;", "∞"},
      {"&ang;", "∠"},
      {"&and;", "∧"},
      {"&or;", "∨"},
      {"&cap;", "∩"},
      {"&cup;", "∪"},
      {"&int;", "∫"},
      {"&there4;", "∴"},
      {"&sim;", "∼"},
      {"&cong;", "≅"},
      {"&asymp;", "≈"},
      {"&ne;", "≠"},
      {"&equiv;", "≡"},
      {"&le;", "≤"},
      {"&ge;", "≥"},
      {"&sub;", "⊂"},
      {"&sup;", "⊃"},
      {"&nsub;", "⊄"},
      {"&sube;", "⊆"},
      {"&supe;", "⊇"},
      {"&oplus;", "⊕"},
      {"&otimes;", "⊗"},
      {"&perp;", "⊥"},
      {"&sdot;", "⋅"},
      {"&loz;", "◊"},
      {"&lceil;", "⌈"},
      {"&rceil;", "⌉"},
      {"&lfloor;", "⌊"},
      {"&rfloor;", "⌋"},
      {"&lang;", "〈"},
      {"&rang;", "〉"},
      {"&larr;", "←"},
      {"&uarr;", "↑"},
      {"&rarr;", "→"},
      {"&darr;", "↓"},
      {"&harr;", "↔"},
      {"&crarr;", "↵"},
      {"&lArr;", "⇐"},
      {"&uArr;", "⇑"},
      {"&rArr;", "⇒"},
      {"&dArr;", "⇓"},
      {"&hArr;", "⇔"},
      {"&bull;", "•"},
      {"&prime;", "′"},
      {"&Prime;", "″"},
      {"&oline;", "‾"},
      {"&frasl;", "⁄"},
      {"&weierp;", "℘"},
      {"&image;", "ℑ"},
      {"&real;", "ℜ"},
      {"&trade;", "™"},
      {"&euro;", "€"},
      {"&alefsym;", "ℵ"},
      {"&spades;", "♠"},
      {"&clubs;", "♣"},
      {"&hearts;", "♥"},
      {"&diams;", "♦"},
      {"&ensp;", " "},
      {"&emsp;", " "},
      {"&thinsp;", " "},
      {"&zwnj;", " "},
      {"&zwj;", " "},
      {"&lrm;", " "},
      {"&rlm;", " "},
      {"&ndash;", "–"},
      {"&mdash;", "—"},
      {"&lsquo;", "'"},
      {"&rsquo;", "'"},
      {"&sbquo;", "'"},
      {"&ldquo;", "\""},
      {"&rdquo;", "\""},
      {"&bdquo;", "\""},
      {"&dagger;", "†"},
      {"&Dagger;", "‡"},
      {"&hellip;", "…"},
      {"&permil;", "‰"},
      {"&lsaquo;", "‹"},
      {"&rsaquo;", "›"},
      {"&#x22;", "\""},
      {"&#x26;", "&"},
      {"&#x3C;", "<"},
      {"&#x3E;", ">"},
      {"&#x27;", "'"},
      {"&#xA0;", " "},
      {"&#xA1;", "¡"},
      {"&#xA2;", "¢"},
      {"&#xA3;", "£"},
      {"&#xA4;", "¤"},
      {"&#xA5;", "¥"},
      {"&#xA6;", "¦"},
      {"&#xA7;", "§"},
      {"&#xA8;", "¨"},
      {"&#xA9;", "©"},
      {"&#xAA;", "ª"},
      {"&#xAB;", "\""},
      {"&#xAC;", "¬"},
      {"&#xAD;", " "},
      {"&#xAE;", "®"},
      {"&#xAF;", "¯"},
      {"&#xB0;", "°"},
      {"&#xB1;", "±"},
      {"&#xB2;", "²"},
      {"&#xB3;", "³"},
      {"&#xB4;", "´"},
      {"&#xB5;", "µ"},
      {"&#xB6;", "¶"},
      {"&#xB7;", "·"},
      {"&#xB8;", "¸"},
      {"&#xB9;", "¹"},
      {"&#xBA;", "º"},
      {"&#xBB;", "\""},
      {"&#xBC;", "¼"},
      {"&#xBD;", "½"},
      {"&#xBE;", "¾"},
      {"&#xBF;", "¿"},
      {"&#xC0;", "À"},
      {"&#xC1;", "Á"},
      {"&#xC2;", "Â"},
      {"&#xC3;", "Ã"},
      {"&#xC4;", "Ä"},
      {"&#xC5;", "Å"},
      {"&#xC6;", "Æ"},
      {"&#xC7;", "Ç"},
      {"&#xC8;", "È"},
      {"&#xC9;", "É"},
      {"&#xCA;", "Ê"},
      {"&#xCB;", "Ë"},
      {"&#xCC;", "Ì"},
      {"&#xCD;", "Í"},
      {"&#xCE;", "Î"},
      {"&#xCF;", "Ï"},
      {"&#xD0;", "Ð"},
      {"&#xD1;", "Ñ"},
      {"&#xD2;", "Ò"},
      {"&#xD3;", "Ó"},
      {"&#xD4;", "Ô"},
      {"&#xD5;", "Õ"},
      {"&#xD6;", "Ö"},
      {"&#xD7;", "×"},
      {"&#xD8;", "Ø"},
      {"&#xD9;", "Ù"},
      {"&#xDA;", "Ú"},
      {"&#xDB;", "Û"},
      {"&#xDC;", "Ü"},
      {"&#xDD;", "Ý"},
      {"&#xDE;", "Þ"},
      {"&#xDF;", "ß"},
      {"&#xE0;", "à"},
      {"&#xE1;", "á"},
      {"&#xE2;", "â"},
      {"&#xE3;", "ã"},
      {"&#xE4;", "ä"},
      {"&#xE5;", "å"},
      {"&#xE6;", "æ"},
      {"&#xE7;", "ç"},
      {"&#xE8;", "è"},
      {"&#xE9;", "é"},
      {"&#xEA;", "ê"},
      {"&#xEB;", "ë"},
      {"&#xEC;", "ì"},
      {"&#xED;", "í"},
      {"&#xEE;", "î"},
      {"&#xEF;", "ï"},
      {"&#xF0;", "ð"},
      {"&#xF1;", "ñ"},
      {"&#xF2;", "ò"},
      {"&#xF3;", "ó"},
      {"&#xF4;", "ô"},
      {"&#xF5;", "õ"},
      {"&#xF6;", "ö"},
      {"&#xF7;", "÷"},
      {"&#xF8;", "ø"},
      {"&#xF9;", "ù"},
      {"&#xFA;", "ú"},
      {"&#xFB;", "û"},
      {"&#xFC;", "ü"},
      {"&#xFD;", "ý"},
      {"&#xFE;", "þ"},
      {"&#xFF;", "ÿ"},
      {"&#x152;", "Œ"},
      {"&#x153;", "œ"},
      {"&#x160;", "Š"},
      {"&#x161;", "š"},
      {"&#x178;", "Ÿ"},
      {"&#x192;", "ƒ"},
      {"&#x2C6;", "ˆ"},
      {"&#x2DC;", "˜"},
      {"&#x391;", "Α"},
      {"&#x3B1;", "α"},
      {"&#x392;", "Β"},
      {"&#x3B2;", "β"},
      {"&#x393;", "Γ"},
      {"&#x3B3;", "γ"},
      {"&#x394;", "Δ"},
      {"&#x3B4;", "δ"},
      {"&#x395;", "Ε"},
      {"&#x3B5;", "ε"},
      {"&#x396;", "Ζ"},
      {"&#x3B6;", "ζ"},
      {"&#x397;", "Η"},
      {"&#x3B7;", "η"},
      {"&#x398;", "Θ"},
      {"&#x3B8;", "θ"},
      {"&#x399;", "Ι"},
      {"&#x3B9;", "ι"},
      {"&#x39A;", "Κ"},
      {"&#x3BA;", "κ"},
      {"&#x39B;", "Λ"},
      {"&#x3BB;", "λ"},
      {"&#x39C;", "Μ"},
      {"&#x3BC;", "μ"},
      {"&#x39D;", "Ν"},
      {"&#x3BD;", "ν"},
      {"&#x39E;", "Ξ"},
      {"&#x3BE;", "ξ"},
      {"&#x39F;", "Ο"},
      {"&#x3BF;", "ο"},
      {"&#x3A0;", "Π"},
      {"&#x3C0;", "π"},
      {"&#x3A1;", "Ρ"},
      {"&#x3C1;", "ρ"},
      {"&#x3A3;", "Σ"},
      {"&#x3C2;", "ς"},
      {"&#x3C3;", "σ"},
      {"&#x3A4;", "Τ"},
      {"&#x3C4;", "τ"},
      {"&#x3A5;", "Υ"},
      {"&#x3C5;", "υ"},
      {"&#x3A6;", "Φ"},
      {"&#x3C6;", "φ"},
      {"&#x3A7;", "Χ"},
      {"&#x3C7;", "χ"},
      {"&#x3A8;", "Ψ"},
      {"&#x3C8;", "ψ"},
      {"&#x3A9;", "Ω"},
      {"&#x3C9;", "ω"},
      {"&#x3D1;", "ϑ"},
      {"&#x3D2;", "ϒ"},
      {"&#x3D6;", "ϖ"},
      {"&#x2200;", "∀"},
      {"&#x2202;", "∂"},
      {"&#x2203;", "∃"},
      {"&#x2205;", "∅"},
      {"&#x2207;", "∇"},
      {"&#x2208;", "∈"},
      {"&#x2209;", "∉"},
      {"&#x220B;", "∋"},
      {"&#x220F;", "∏"},
      {"&#x2211;", "∑"},
      {"&#x2212;", "−"},
      {"&#x2217;", "∗"},
      {"&#x221A;", "√"},
      {"&#x221D;", "∝"},
      {"&#x221E;", "∞"},
      {"&#x2220;", "∠"},
      {"&#x2227;", "∧"},
      {"&#x2228;", "∨"},
      {"&#x2229;", "∩"},
      {"&#x222A;", "∪"},
      {"&#x222B;", "∫"},
      {"&#x2234;", "∴"},
      {"&#x223C;", "∼"},
      {"&#x2245;", "≅"},
      {"&#x2248;", "≈"},
      {"&#x2260;", "≠"},
      {"&#x2261;", "≡"},
      {"&#x2264;", "≤"},
      {"&#x2265;", "≥"},
      {"&#x2282;", "⊂"},
      {"&#x2283;", "⊃"},
      {"&#x2284;", "⊄"},
      {"&#x2286;", "⊆"},
      {"&#x2287;", "⊇"},
      {"&#x2295;", "⊕"},
      {"&#x2297;", "⊗"},
      {"&#x22A5;", "⊥"},
      {"&#x22C5;", "⋅"},
      {"&#x25CA;", "◊"},
      {"&#x2308;", "⌈"},
      {"&#x2309;", "⌉"},
      {"&#x230A;", "⌊"},
      {"&#x230B;", "⌋"},
      {"&#x2329;", "〈"},
      {"&#x232A;", "〉"},
      {"&#x2190;", "←"},
      {"&#x2191;", "↑"},
      {"&#x2192;", "→"},
      {"&#x2193;", "↓"},
      {"&#x2194;", "↔"},
      {"&#x21B5;", "↵"},
      {"&#x21D0;", "⇐"},
      {"&#x21D1;", "⇑"},
      {"&#x21D2;", "⇒"},
      {"&#x21D3;", "⇓"},
      {"&#x21D4;", "⇔"},
      {"&#x2022;", "•"},
      {"&#x2032;", "′"},
      {"&#x2033;", "″"},
      {"&#x203E;", "‾"},
      {"&#x2044;", "⁄"},
      {"&#x2118;", "℘"},
      {"&#x2111;", "ℑ"},
      {"&#x211C;", "ℜ"},
      {"&#x2122;", "™"},
      {"&#x20AC;", "€"},
      {"&#x2135;", "ℵ"},
      {"&#x2660;", "♠"},
      {"&#x2663;", "♣"},
      {"&#x2665;", "♥"},
      {"&#x2666;", "♦"},
      {"&#x2002;", " "},
      {"&#x2003;", " "},
      {"&#x2009;", " "},
      {"&#x200C;", " "},
      {"&#x200D;", " "},
      {"&#x200E;", " "},
      {"&#x200F;", " "},
      {"&#x2013;", "–"},
      {"&#x2014;", "—"},
      {"&#x2018;", "'"},
      {"&#x2019;", "'"},
      {"&#x201A;", "'"},
      {"&#x201C;", "\""},
      {"&#x201D;", "\""},
      {"&#x201E;", "\""},
      {"&#x2020;", "†"},
      {"&#x2021;", "‡"},
      {"&#x2026;", "…"},
      {"&#x2030;", "‰"},
      {"&#x2039;", "‹"},
      {"&#x203A;", "›"},
      {"&#x2070;", "⁰"},
      {"&#x00B9;", "¹"},
      {"&#x00B2;", "²"},
      {"&#x00B3;", "³"},
      {"&#x2074;", "⁴"},
      {"&#x2075;", "⁵"},
      {"&#x2076;", "⁶"},
      {"&#x2077;", "⁷"},
      {"&#x2078;", "⁸"},
      {"&#x2079;", "⁹"},
      {"&#x2080;", "₀"},
      {"&#x2081;", "₁"},
      {"&#x2082;", "₂"},
      {"&#x2083;", "₃"},
      {"&#x2084;", "₄"},
      {"&#x2085;", "₅"},
      {"&#x2086;", "₆"},
      {"&#x2087;", "₇"},
      {"&#x2088;", "₈"},
      {"&#x2089;", "₉"},
      {"&#34;", "\""},
      {"&#38;", "&"},
      {"&#60;", "<"},
      {"&#62;", ">"},
      {"&#39;", "'"},
      {"&#160;", " "},
      {"&#161;", "¡"},
      {"&#162;", "¢"},
      {"&#163;", "£"},
      {"&#164;", "¤"},
      {"&#165;", "¥"},
      {"&#166;", "¦"},
      {"&#167;", "§"},
      {"&#168;", "¨"},
      {"&#169;", "©"},
      {"&#170;", "ª"},
      {"&#171;", "\""},
      {"&#172;", "¬"},
      {"&#173;", " "},
      {"&#174;", "®"},
      {"&#175;", "¯"},
      {"&#176;", "°"},
      {"&#177;", "±"},
      {"&#178;", "²"},
      {"&#179;", "³"},
      {"&#180;", "´"},
      {"&#181;", "µ"},
      {"&#182;", "¶"},
      {"&#183;", "·"},
      {"&#184;", "¸"},
      {"&#185;", "¹"},
      {"&#186;", "º"},
      {"&#187;", "\""},
      {"&#188;", "¼"},
      {"&#189;", "½"},
      {"&#190;", "¾"},
      {"&#191;", "¿"},
      {"&#192;", "À"},
      {"&#193;", "Á"},
      {"&#194;", "Â"},
      {"&#195;", "Ã"},
      {"&#196;", "Ä"},
      {"&#197;", "Å"},
      {"&#198;", "Æ"},
      {"&#199;", "Ç"},
      {"&#200;", "È"},
      {"&#201;", "É"},
      {"&#202;", "Ê"},
      {"&#203;", "Ë"},
      {"&#204;", "Ì"},
      {"&#205;", "Í"},
      {"&#206;", "Î"},
      {"&#207;", "Ï"},
      {"&#208;", "Ð"},
      {"&#209;", "Ñ"},
      {"&#210;", "Ò"},
      {"&#211;", "Ó"},
      {"&#212;", "Ô"},
      {"&#213;", "Õ"},
      {"&#214;", "Ö"},
      {"&#215;", "×"},
      {"&#216;", "Ø"},
      {"&#217;", "Ù"},
      {"&#218;", "Ú"},
      {"&#219;", "Û"},
      {"&#220;", "Ü"},
      {"&#221;", "Ý"},
      {"&#222;", "Þ"},
      {"&#223;", "ß"},
      {"&#224;", "à"},
      {"&#225;", "á"},
      {"&#226;", "â"},
      {"&#227;", "ã"},
      {"&#228;", "ä"},
      {"&#229;", "å"},
      {"&#230;", "æ"},
      {"&#231;", "ç"},
      {"&#232;", "è"},
      {"&#233;", "é"},
      {"&#234;", "ê"},
      {"&#235;", "ë"},
      {"&#236;", "ì"},
      {"&#237;", "í"},
      {"&#238;", "î"},
      {"&#239;", "ï"},
      {"&#240;", "ð"},
      {"&#241;", "ñ"},
      {"&#242;", "ò"},
      {"&#243;", "ó"},
      {"&#244;", "ô"},
      {"&#245;", "õ"},
      {"&#246;", "ö"},
      {"&#247;", "÷"},
      {"&#248;", "ø"},
      {"&#249;", "ù"},
      {"&#250;", "ú"},
      {"&#251;", "û"},
      {"&#252;", "ü"},
      {"&#253;", "ý"},
      {"&#254;", "þ"},
      {"&#255;", "ÿ"},
      {"&#338;", "Œ"},
      {"&#339;", "œ"},
      {"&#352;", "Š"},
      {"&#353;", "š"},
      {"&#376;", "Ÿ"},
      {"&#402;", "ƒ"},
      {"&#710;", "ˆ"},
      {"&#732;", "˜"},
      {"&#913;", "Α"},
      {"&#945;", "α"},
      {"&#914;", "Β"},
      {"&#946;", "β"},
      {"&#915;", "Γ"},
      {"&#947;", "γ"},
      {"&#916;", "Δ"},
      {"&#948;", "δ"},
      {"&#917;", "Ε"},
      {"&#949;", "ε"},
      {"&#918;", "Ζ"},
      {"&#950;", "ζ"},
      {"&#919;", "Η"},
      {"&#951;", "η"},
      {"&#920;", "Θ"},
      {"&#952;", "θ"},
      {"&#921;", "Ι"},
      {"&#953;", "ι"},
      {"&#922;", "Κ"},
      {"&#954;", "κ"},
      {"&#923;", "Λ"},
      {"&#955;", "λ"},
      {"&#924;", "Μ"},
      {"&#956;", "μ"},
      {"&#925;", "Ν"},
      {"&#957;", "ν"},
      {"&#926;", "Ξ"},
      {"&#958;", "ξ"},
      {"&#927;", "Ο"},
      {"&#959;", "ο"},
      {"&#928;", "Π"},
      {"&#960;", "π"},
      {"&#929;", "Ρ"},
      {"&#961;", "ρ"},
      {"&#931;", "Σ"},
      {"&#962;", "ς"},
      {"&#963;", "σ"},
      {"&#932;", "Τ"},
      {"&#964;", "τ"},
      {"&#933;", "Υ"},
      {"&#965;", "υ"},
      {"&#934;", "Φ"},
      {"&#966;", "φ"},
      {"&#935;", "Χ"},
      {"&#967;", "χ"},
      {"&#936;", "Ψ"},
      {"&#968;", "ψ"},
      {"&#937;", "Ω"},
      {"&#969;", "ω"},
      {"&#977;", "ϑ"},
      {"&#978;", "ϒ"},
      {"&#982;", "ϖ"},
      {"&#8704;", "∀"},
      {"&#8706;", "∂"},
      {"&#8707;", "∃"},
      {"&#8709;", "∅"},
      {"&#8711;", "∇"},
      {"&#8712;", "∈"},
      {"&#8713;", "∉"},
      {"&#8715;", "∋"},
      {"&#8719;", "∏"},
      {"&#8721;", "∑"},
      {"&#8722;", "−"},
      {"&#8727;", "∗"},
      {"&#8730;", "√"},
      {"&#8733;", "∝"},
      {"&#8734;", "∞"},
      {"&#8736;", "∠"},
      {"&#8743;", "∧"},
      {"&#8744;", "∨"},
      {"&#8745;", "∩"},
      {"&#8746;", "∪"},
      {"&#8747;", "∫"},
      {"&#8756;", "∴"},
      {"&#8764;", "∼"},
      {"&#8773;", "≅"},
      {"&#8776;", "≈"},
      {"&#8800;", "≠"},
      {"&#8801;", "≡"},
      {"&#8804;", "≤"},
      {"&#8805;", "≥"},
      {"&#8834;", "⊂"},
      {"&#8835;", "⊃"},
      {"&#8836;", "⊄"},
      {"&#8838;", "⊆"},
      {"&#8839;", "⊇"},
      {"&#8853;", "⊕"},
      {"&#8855;", "⊗"},
      {"&#8869;", "⊥"},
      {"&#8901;", "⋅"},
      {"&#9674;", "◊"},
      {"&#8968;", "⌈"},
      {"&#8969;", "⌉"},
      {"&#8970;", "⌊"},
      {"&#8971;", "⌋"},
      {"&#9001;", "〈"},
      {"&#9002;", "〉"},
      {"&#8592;", "←"},
      {"&#8593;", "↑"},
      {"&#8594;", "→"},
      {"&#8595;", "↓"},
      {"&#8596;", "↔"},
      {"&#8629;", "↵"},
      {"&#8656;", "⇐"},
      {"&#8657;", "⇑"},
      {"&#8658;", "⇒"},
      {"&#8659;", "⇓"},
      {"&#8660;", "⇔"},
      {"&#8226;", "•"},
      {"&#8242;", "′"},
      {"&#8243;", "″"},
      {"&#8254;", "‾"},
      {"&#8260;", "⁄"},
      {"&#8472;", "℘"},
      {"&#8465;", "ℑ"},
      {"&#8476;", "ℜ"},
      {"&#8482;", "™"},
      {"&#8364;", "€"},
      {"&#8501;", "ℵ"},
      {"&#9824;", "♠"},
      {"&#9827;", "♣"},
      {"&#9829;", "♥"},
      {"&#9830;", "♦"},
      {"&#8194;", " "},
      {"&#8195;", " "},
      {"&#8201;", " "},
      {"&#8204;", " "},
      {"&#8205;", " "},
      {"&#8206;", " "},
      {"&#8207;", " "},
      {"&#8211;", "–"},
      {"&#8212;", "—"},
      {"&#8216;", "'"},
      {"&#8217;", "'"},
      {"&#8218;", "'"},
      {"&#8220;", "\""},
      {"&#8221;", "\""},
      {"&#8222;", "\""},
      {"&#8224;", "†"},
      {"&#8225;", "‡"},
      {"&#8230;", "…"},
      {"&#8240;", "‰"},
      {"&#8249;", "‹"},
      {"&#8250;", "›"},
      {"&#0185;", "⁰"},
      {"&#8304;", "¹"},
      {"&#0178;", "²"},
      {"&#0179;", "³"},
      {"&#8308;", "⁴"},
      {"&#8309;", "⁵"},
      {"&#8310;", "⁶"},
      {"&#8311;", "⁷"},
      {"&#8312;", "⁸"},
      {"&#8313;", "⁹"},
      {"&#8320;", "₀"},
      {"&#8321;", "₁"},
      {"&#8322;", "₂"},
      {"&#8323;", "₃"},
      {"&#8324;", "₄"},
      {"&#8325;", "₅"},
      {"&#8326;", "₆"},
      {"&#8327;", "₇"},
      {"&#8328;", "₈"},
      {"&#8329;", "₉"},
      {"«", "\""},
      {"»", "\""},
      {"„", "\""},
      {"“", "\""},
      {"‘", "'"},
      {"’", "'"},
      {"‚", "'"}
    };

    public override string DisplayName => Resources.StandardCleanup;

    protected override string Execute(string input)
    {
      return _dictionary.Aggregate(input, (current, entry) => current.Replace(entry.Key, entry.Value));
    }
  }
}