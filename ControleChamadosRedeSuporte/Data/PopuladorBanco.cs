using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleChamadosRedeSuporte.Models;

namespace ControleChamadosRedeSuporte.Data
{
    public class PopuladorBanco
    {//injeção de dependência, toda vez que um PopuladorBanco for criado
     //ele vai receber context
        private CCRSContext _context;

        public PopuladorBanco(CCRSContext context)
        {
            _context = context;
        }

        public void Seed()//método para povoar que deve ser adicionado no Startup.cs
        {                          //no método Configure
            if (_context.Graduacao.Any() || _context.TipoProblema.Any() || _context.Unidade.Any())
            {
                //testa se há algum registro na tab Graduacao ou TipoProblema
                //caso haja não faz nada
                return;
            }
            //polulando as tab
            Graduacao g1 = new Graduacao(1,"Cel");
            Graduacao g2 = new Graduacao(2, "Ten Cel");
            Graduacao g3 = new Graduacao(3, "Maj");
            Graduacao g4 = new Graduacao(4, "Cap");
            Graduacao g5 = new Graduacao(5, "1º Ten");
            Graduacao g6 = new Graduacao(6, "2º Ten");
            Graduacao g7 = new Graduacao(7, "Asp");
            Graduacao g8 = new Graduacao(8, "Sub Ten");
            Graduacao g9 = new Graduacao(9, "1º Sgt");
            Graduacao g10 = new Graduacao(10, "2º Sgt");
            Graduacao g11 = new Graduacao(11, "3º Sgt");
            Graduacao g12 = new Graduacao(12, "Cb");
            Graduacao g13 = new Graduacao(13, "Sd");

            TipoProblema t1 = new TipoProblema(1, "Sem conexão com a internet/intranet");
            TipoProblema t2 = new TipoProblema(2, "Computador não imprime");
            TipoProblema t3 = new TipoProblema(3, "Computador com mal funcionamento");
            TipoProblema t4 = new TipoProblema(4, "Falha no sistema");
            TipoProblema t5 = new TipoProblema(5, "Reparo na rede");
            TipoProblema t6 = new TipoProblema(6, "Outro");

            Unidade u1 = new Unidade(1, "1ª CIPM");
            Unidade u2 = new Unidade(2, "1º CPA");
            Unidade u3 = new Unidade(3, "1ª DPJM");
            Unidade u4 = new Unidade(4, "10º BPM");
            Unidade u5 = new Unidade(5, "11º BPM");
            Unidade u6 = new Unidade(6, "12º BPM");
            Unidade u7 = new Unidade(7, "14º BPM");
            Unidade u8 = new Unidade(8, "15º BPM");
            Unidade u9 = new Unidade(9, "16º BPM");
            Unidade u10 = new Unidade(10, "17º BPM");
            Unidade u11 = new Unidade(11, "18º BPM");
            Unidade u12 = new Unidade(12, "19º BPM");
            Unidade u13 = new Unidade(13, "2º BPM");
            Unidade u14 = new Unidade(14, "2º CPA");
            Unidade u15 = new Unidade(15, "2ª DPJM");
            Unidade u16 = new Unidade(16, "20º BPM");
            Unidade u17 = new Unidade(17, "21º BPM");
            Unidade u18 = new Unidade(18, "22º BPM");
            Unidade u19 = new Unidade(19, "23º BPM");
            Unidade u20 = new Unidade(20, "24º BPM");
            Unidade u21 = new Unidade(21, "25º BPM");
            Unidade u22 = new Unidade(22, "26º BPM");
            Unidade u23 = new Unidade(23, "27º BPM");
            Unidade u24 = new Unidade(24, "28º BPM");
            Unidade u25 = new Unidade(25, "29º BPM");
            Unidade u26 = new Unidade(26, "3º BPM");
            Unidade u27 = new Unidade(27, "3º CPA");
            Unidade u28 = new Unidade(28, "3ª DPJM");
            Unidade u29 = new Unidade(29, "30º BPM");
            Unidade u30 = new Unidade(30, "31º BPM");
            Unidade u31 = new Unidade(31, "32º BPM");
            Unidade u32 = new Unidade(32, "33º BPM");
            Unidade u33 = new Unidade(33, "34º BPM");
            Unidade u34 = new Unidade(34, "35º BPM");
            Unidade u35 = new Unidade(35, "36º BPM");
            Unidade u36 = new Unidade(36, "37º BPM");
            Unidade u37 = new Unidade(37, "38º BPM");
            Unidade u38 = new Unidade(38, "39º BPM");
            Unidade u39 = new Unidade(39, "4º BPM");
            Unidade u40 = new Unidade(40, "4º CPA");
            Unidade u41 = new Unidade(41, "4ª DPJM");
            Unidade u42 = new Unidade(42, "40º BPM");
            Unidade u43 = new Unidade(43, "41º BPM");
            Unidade u44 = new Unidade(44, "5º BPM");
            Unidade u45 = new Unidade(45, "5º CPA");
            Unidade u46 = new Unidade(46, "5ª DPJM");
            Unidade u47 = new Unidade(47, "6º BPM");
            Unidade u48 = new Unidade(48, "6º CPA");
            Unidade u49 = new Unidade(49, "6ª DPJM");
            Unidade u50 = new Unidade(50, "7º BPM");
            Unidade u51 = new Unidade(51, "7º CPA");
            Unidade u52 = new Unidade(52, "7ª DPJM");
            Unidade u53 = new Unidade(53, "8º BPM");
            Unidade u54 = new Unidade(54, "8ª DPJM");
            Unidade u55 = new Unidade(55, "9º BPM");
            Unidade u56 = new Unidade(56, "AJG");
            Unidade u57 = new Unidade(57, "APM");
            Unidade u58 = new Unidade(58, "BAC");
            Unidade u59 = new Unidade(59, "BEPE");
            Unidade u60 = new Unidade(60, "BOPE");
            Unidade u61 = new Unidade(61, "BPCHOQUE");
            Unidade u62 = new Unidade(62, "BPRV");
            Unidade u63 = new Unidade(63, "BPTUR");
            Unidade u64 = new Unidade(64, "BPVE");
            Unidade u65 = new Unidade(65, "CAES");
            Unidade u66 = new Unidade(66, "CCC");
            Unidade u67 = new Unidade(67, "CCOMSOC");
            Unidade u68 = new Unidade(68, "CCPMERJ");
            Unidade u69 = new Unidade(69, "CCRIM");
            Unidade u70 = new Unidade(70, "CECOPOM");
            Unidade u71 = new Unidade(71, "CEFD");
            Unidade u72 = new Unidade(72, "CETIC");
            Unidade u73 = new Unidade(73, "CFAP");
            Unidade u74 = new Unidade(74, "CFRPM");
            Unidade u75 = new Unidade(75, "CI");
            Unidade u76 = new Unidade(76, "CIEAT");
            Unidade u77 = new Unidade(77, "CINTPM");
            Unidade u78 = new Unidade(78, "CMARM");
            Unidade u79 = new Unidade(79, "COE");
            Unidade u80 = new Unidade(80, "CONTROLADORIA");
            Unidade u81 = new Unidade(81, "CPAM");
            Unidade u82 = new Unidade(82, "CPE");
            Unidade u83 = new Unidade(83, "CPM CAMPO GRANDE");
            Unidade u84 = new Unidade(84, "CPM CAXIAS");
            Unidade u85 = new Unidade(85, "CPM MUSICA");
            Unidade u86 = new Unidade(86, "CPM NITEROI");
            Unidade u87 = new Unidade(87, "CPP");
            Unidade u88 = new Unidade(88, "CPROEIS");
            Unidade u89 = new Unidade(89, "CQPS");
            Unidade u90 = new Unidade(90, "CRSP");
            Unidade u91 = new Unidade(91, "DAS");
            Unidade u92 = new Unidade(92, "DCMUN");
            Unidade u93 = new Unidade(93, "DCP");
            Unidade u94 = new Unidade(94, "DF");
            Unidade u95 = new Unidade(95, "DGAF");
            Unidade u96 = new Unidade(96, "DGAL");
            Unidade u97 = new Unidade(97, "DGEI");
            Unidade u98 = new Unidade(98, "DGO");
            Unidade u99 = new Unidade(99, "DGP");
            Unidade u100 = new Unidade(100, "DGS");
            Unidade u101 = new Unidade(101, "DIP");
            Unidade u102 = new Unidade(102, "DOR");
            Unidade u103 = new Unidade(103, "DP/PMERJ");
            Unidade u104 = new Unidade(104, "DPA");
            Unidade u105 = new Unidade(105, "DPAS");
            Unidade u106 = new Unidade(106, "DT");
            Unidade u107 = new Unidade(107, "EMG");
            Unidade u108 = new Unidade(108, "ESPM");
            Unidade u109 = new Unidade(109, "GAM");
            Unidade u110 = new Unidade(110, "GAPH");
            Unidade u111 = new Unidade(111, "GCG");
            Unidade u112 = new Unidade(112, "GEPE");
            Unidade u113 = new Unidade(113, "GPFER");
            Unidade u114 = new Unidade(114, "HCPM");
            Unidade u115 = new Unidade(115, "HPM/NIT");
            Unidade u116 = new Unidade(116, "OCPM");
            Unidade u117 = new Unidade(117, "PEC-RCECS");
            Unidade u118 = new Unidade(118, "PM1");
            Unidade u119 = new Unidade(119, "PM3");
            Unidade u120 = new Unidade(120, "PM4");
            Unidade u121 = new Unidade(121, "PPM/CAMPOS");
            Unidade u122 = new Unidade(122, "PPM/CAS");
            Unidade u123 = new Unidade(123, "PPM/OLARIA");
            Unidade u124 = new Unidade(124, "PPM/SJM");
            Unidade u125 = new Unidade(125, "RECON");
            Unidade u126 = new Unidade(126, "RPMONT");
            Unidade u127 = new Unidade(127, "SAR");
            Unidade u128 = new Unidade(128, "SCAV");
            Unidade u129 = new Unidade(129, "SPM");
            Unidade u130 = new Unidade(130, "UPP ALEMAO");
            Unidade u131 = new Unidade(131, "UPP ANDARAI");
            Unidade u132 = new Unidade(132, "UPP ARARA MANDELA");
            Unidade u133 = new Unidade(133, "UPP BABILONIA");
            Unidade u134 = new Unidade(134, "UPP BARREIRA DO TUIUTI");
            Unidade u135 = new Unidade(135, "UPP BOREL");
            Unidade u136 = new Unidade(136, "UPP CAJU");
            Unidade u137 = new Unidade(137, "UPP CDD");
            Unidade u138 = new Unidade(138, "UPP CERRO CORA");
            Unidade u139 = new Unidade(139, "UPP CHATUBA");
            Unidade u140 = new Unidade(140, "UPP FAZENDINHA");
            Unidade u141 = new Unidade(141, "UPP FORMIGA");
            Unidade u142 = new Unidade(142, "UPP JACAREZINHO");
            Unidade u143 = new Unidade(143, "UPP MACACO");
            Unidade u144 = new Unidade(144, "UPP MANGUEIRA");
            Unidade u145 = new Unidade(145, "UPP MANGUINHOS");
            Unidade u146 = new Unidade(146, "UPP NOVA BRASILIA");
            Unidade u147 = new Unidade(147, "UPP PAVAO / CANTAGALO");
            Unidade u148 = new Unidade(148, "UPP PRAZERES");
            Unidade u149 = new Unidade(149, "UPP PROVIDENCIA");
            Unidade u150 = new Unidade(150, "UPP SALGUEIRO");
            Unidade u151 = new Unidade(151, "UPP SANTA MARTA");
            Unidade u152 = new Unidade(152, "UPP SAO JOAO");
            Unidade u153 = new Unidade(153, "UPP TABAJARAS");
            Unidade u154 = new Unidade(154, "UPP TURANO");
            Unidade u155 = new Unidade(155, "UPP VIDIGAL");
            Unidade u156 = new Unidade(156, "UPPMERJ");

            _context.Graduacao.AddRange(g1,g2,g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13);
            _context.TipoProblema.AddRange(t1, t2, t3, t4, t5, t6);
            _context.Unidade.AddRange(u1,u2,u3,u4,u5,u6,u7,
u8,
u9,
u10,
u11,
u12,
u13,
u14,
u15,
u16,
u17,
u18,
u19,
u20,
u21,
u22,
u23,
u24,
u25,
u26,
u27,
u28,
u29,
u30,
u31,
u32,
u33,
u34,
u35,
u36,
u37,
u38,
u39,
u40,
u41,
u42,
u43,
u44,
u45,
u46,
u47,
u48,
u49,
u50,
u51,
u52,
u53,
u54,
u55,
u56,
u57,
u58,
u59,
u60,
u61,
u62,
u63,
u64,
u65,
u66,
u67,
u68,
u69,
u70,
u71,
u72,
u73,
u74,
u75,
u76,
u77,
u78,
u79,
u80,
u81,
u82,
u83,
u84,
u85,
u86,
u87,
u88,
u89,
u90,
u91,
u92,
u93,
u94,
u95,
u96,
u97,
u98,
u99,
u100,
u101,
u102,
u103,
u104,
u105,
u106,
u107,
u108,
u109,
u110,
u111,
u112,
u113,
u114,
u115,
u116,
u117,
u118,
u119,
u120,
u121,
u122,
u123,
u124,
u125,
u126,
u127,
u128,
u129,
u130,
u131,
u132,
u133,
u134,
u135,
u136,
u137,
u138,
u139,
u140,
u141,
u142,
u143,
u144,
u145,
u146,
u147,
u148,
u149,
u150,
u151,
u152,
u153,
u154,
u155,
u156
);

            _context.SaveChanges();




        }
    }
}
