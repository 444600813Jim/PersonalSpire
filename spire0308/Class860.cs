using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

internal class Class860
{
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private static readonly Hashtable hashtable_1 = new Hashtable();
    private static readonly Hashtable hashtable_2 = new Hashtable();
    private static readonly Hashtable hashtable_3 = new Hashtable();

    static Class860()
    {
        Class791.smethod_0(new object[] { 
            BookmarkStart.b("栨洪", 3), LocaleIDs.af_ZA, BookmarkStart.b("稨稪", 3), LocaleIDs.sq_AL, BookmarkStart.b("栨昪攬", 3), LocaleIDs.am_ET, BookmarkStart.b("栨礪,欮欰", 3), LocaleIDs.ar_DZ, BookmarkStart.b("栨礪,洮礰", 3), LocaleIDs.ar_BH, BookmarkStart.b("栨礪,樮瘰", 3), LocaleIDs.ar_EG, BookmarkStart.b("栨礪,昮怰", 3), LocaleIDs.ar_IQ, BookmarkStart.b("栨礪,攮縰", 3), LocaleIDs.ar_JO, 
            BookmarkStart.b("栨礪,搮昰", 3), LocaleIDs.ar_KW, BookmarkStart.b("栨礪,挮猰", 3), LocaleIDs.ar_LB, BookmarkStart.b("栨礪,挮栰", 3), LocaleIDs.ar_LY, BookmarkStart.b("栨礪,戮瀰", 3), LocaleIDs.ar_MA, BookmarkStart.b("栨礪,怮簰", 3), LocaleIDs.ar_OM, BookmarkStart.b("栨礪,縮瀰", 3), LocaleIDs.ar_QA, BookmarkStart.b("栨礪,簮瀰", 3), LocaleIDs.ar_SA, BookmarkStart.b("栨礪,簮栰", 3), LocaleIDs.ar_SY, 
            BookmarkStart.b("栨礪,笮缰", 3), LocaleIDs.ar_TN, BookmarkStart.b("栨礪,渮琰", 3), LocaleIDs.ar_AE, BookmarkStart.b("栨礪,瘮琰", 3), LocaleIDs.ar_YE, BookmarkStart.b("愨爪", 3), LocaleIDs.hy_AM, BookmarkStart.b("栨砪", 3), LocaleIDs.as_IN, BookmarkStart.b("栨焪,氮栰愲", 3), LocaleIDs.az_Cyrl_AZ, BookmarkStart.b("栨焪,挮瀰朲簴礶", 3), LocaleIDs.az_Latn_AZ, BookmarkStart.b("氨縪", 3), LocaleIDs.eu_ES, 
            BookmarkStart.b("欨渪", 3), LocaleIDs.be_BY, BookmarkStart.b("欨攪", 3), LocaleIDs.bn_IN, BookmarkStart.b("ᤨጪ᤬ᨮ", 3), LocaleIDs.bn_BD, BookmarkStart.b("ᬨᬪᰬ渮", 3), LocaleIDs.bs_Cyrl_BA, BookmarkStart.b("ᠨἪᰬ渮", 3), LocaleIDs.bs_Latn_BA, BookmarkStart.b("欨氪", 3), LocaleIDs.bg_BG, BookmarkStart.b("搨爪", 3), LocaleIDs.my_MM, BookmarkStart.b("樨横", 3), LocaleIDs.ca_ES, 
            BookmarkStart.b("樨挪缬", 3), LocaleIDs.chr_US, BookmarkStart.b("猨挪,朮稰", 3), LocaleIDs.zh_HK, BookmarkStart.b("猨挪,戮縰", 3), LocaleIDs.zh_MO, BookmarkStart.b("猨挪,氮缰", 3), LocaleIDs.zh_CN, BookmarkStart.b("猨挪,簮瘰", 3), LocaleIDs.zh_SG, BookmarkStart.b("猨挪,笮昰", 3), LocaleIDs.zh_TW, BookmarkStart.b("稨挪", 3), LocaleIDs.hr_BA, BookmarkStart.b("愨礪", 3), LocaleIDs.hr_HR, 
            BookmarkStart.b("樨砪", 3), LocaleIDs.cs_CZ, BookmarkStart.b("洨横", 3), LocaleIDs.da_DK, BookmarkStart.b("洨截第", 3), LocaleIDs.dv_MV, BookmarkStart.b("木未", 3), LocaleIDs.nl_NL, BookmarkStart.b("木未,洮琰", 3), LocaleIDs.nl_BE, BookmarkStart.b("ᤨἪᬬ᤮", 3), LocaleIDs.bin_NG, BookmarkStart.b("氨攪,渮搰", 3), LocaleIDs.en_AU, BookmarkStart.b("氨攪,洮欰", 3), LocaleIDs.en_BZ, 
            BookmarkStart.b("氨攪,氮瀰", 3), LocaleIDs.en_CA, BookmarkStart.b("氨攪,氮瀰愲朴縶笸縺簼焾", 3), LocaleIDs.en_029, BookmarkStart.b("氨攪,朮稰", 3), LocaleIDs.en_HK, BookmarkStart.b("氨攪,昮缰", 3), LocaleIDs.en_IN, BookmarkStart.b("氨攪,昮田", 3), LocaleIDs.en_ID, BookmarkStart.b("氨攪,昮琰", 3), LocaleIDs.en_IE, BookmarkStart.b("氨攪,攮簰", 3), LocaleIDs.en_JM, BookmarkStart.b("氨攪,戮栰", 3), LocaleIDs.en_MY, 
            BookmarkStart.b("氨攪,愮欰", 3), LocaleIDs.en_NZ, BookmarkStart.b("氨攪,缮礰", 3), LocaleIDs.en_PH, BookmarkStart.b("氨攪,簮瘰", 3), LocaleIDs.en_SG, BookmarkStart.b("氨攪,甮瀰", 3), LocaleIDs.en_ZA, BookmarkStart.b("氨攪,笮攰", 3), LocaleIDs.en_TT, BookmarkStart.b("氨攪,栮猰", 3), LocaleIDs.en_GB, BookmarkStart.b("氨攪,種戰", 3), LocaleIDs.en_US, BookmarkStart.b("氨攪,甮昰", 3), LocaleIDs.en_ZW, 
            BookmarkStart.b("氨缪", 3), LocaleIDs.et_EE, BookmarkStart.b("漨搪", 3), LocaleIDs.fo_FO, BookmarkStart.b("ᤨἪᬬᬮ", 3), LocaleIDs.fil_PH, BookmarkStart.b("漨截", 3), LocaleIDs.fi_FI, BookmarkStart.b("漨礪,洮琰", 3), LocaleIDs.fr_BE, BookmarkStart.b("漨礪,氮簰", 3), LocaleIDs.fr_CM, BookmarkStart.b("漨礪,氮瀰", 3), LocaleIDs.fr_CA, BookmarkStart.b("漨礪,氮田", 3), LocaleIDs.fr_CD, 
            BookmarkStart.b("漨礪,氮砰", 3), LocaleIDs.fr_CI, BookmarkStart.b("漨礪", 3), LocaleIDs.fr_FR, BookmarkStart.b("漨礪,朮攰", 3), LocaleIDs.fr_HT, BookmarkStart.b("漨礪,挮搰", 3), LocaleIDs.fr_LU, BookmarkStart.b("漨礪,戮細", 3), LocaleIDs.fr_ML, BookmarkStart.b("漨礪,戮爰", 3), LocaleIDs.fr_MC, BookmarkStart.b("漨礪,戮瀰", 3), LocaleIDs.fr_MA, BookmarkStart.b("漨礪,紮琰", 3), LocaleIDs.fr_RE, 
            BookmarkStart.b("漨礪,簮缰", 3), LocaleIDs.fr_SN, BookmarkStart.b("漨礪,氮礰", 3), LocaleIDs.fr_CH, BookmarkStart.b("漨礪,砮砰紲焴縶簸栺", 3), LocaleIDs.fr_fr_WINDIES, BookmarkStart.b("漨爪", 3), LocaleIDs.fy_NL, BookmarkStart.b("ᤨἪᬬᠮ", 3), LocaleIDs.ff_NG, BookmarkStart.b("渨漪", 3), LocaleIDs.gd_GB, BookmarkStart.b("渨未", 3), LocaleIDs.gl_ES, BookmarkStart.b("渨渪戬.稰爲愴", 3), LocaleIDs.ka_GE, 
            BookmarkStart.b("洨渪,渮攰", 3), LocaleIDs.de_AT, BookmarkStart.b("洨渪", 3), LocaleIDs.de_DE, BookmarkStart.b("洨渪,挮砰", 3), LocaleIDs.de_LI, BookmarkStart.b("洨渪,挮搰", 3), LocaleIDs.de_LU, BookmarkStart.b("洨渪,氮礰", 3), LocaleIDs.de_CH, BookmarkStart.b("氨未", 3), LocaleIDs.el_GR, BookmarkStart.b("渨攪", 3), LocaleIDs.gn_PY, BookmarkStart.b("渨縪", 3), LocaleIDs.gu_IN, 
            BookmarkStart.b("愨横", 3), LocaleIDs.ha_Latn_NG, BookmarkStart.b("ᤨἪᨬᨮ", 3), LocaleIDs.haw_US, BookmarkStart.b("愨渪", 3), LocaleIDs.he_IL, BookmarkStart.b("愨截", 3), LocaleIDs.hi_IN, BookmarkStart.b("愨縪", 3), LocaleIDs.hu_HU, BookmarkStart.b("ᤨἪᬬᘮ", 3), LocaleIDs.ibb_NG, BookmarkStart.b("怨砪", 3), LocaleIDs.is_IS, BookmarkStart.b("ᤨἪᨬἮ", 3), LocaleIDs.ig_NG, 
            BookmarkStart.b("怨攪", 3), LocaleIDs.id_ID, BookmarkStart.b("怨怪砬", 3), LocaleIDs.iu_Cans_CA, BookmarkStart.b("ᤨጪᠬ欮", 3), LocaleIDs.iu_Latn_CA, BookmarkStart.b("渨横", 3), LocaleIDs.ga_IE, BookmarkStart.b("怨缪", 3), LocaleIDs.it_IT, BookmarkStart.b("怨缪,氮礰", 3), LocaleIDs.it_CH, BookmarkStart.b("挨横", 3), LocaleIDs.ja_JP, BookmarkStart.b("戨攪", 3), LocaleIDs.kn_IN, 
            BookmarkStart.b("ᤨἪᨬḮ", 3), LocaleIDs.kr_NG, BookmarkStart.b("戨砪,昮缰", 3), LocaleIDs.ks_Deva, BookmarkStart.b("戨砪", 3), LocaleIDs.ks_Arab, BookmarkStart.b("戨焪", 3), LocaleIDs.kk_KZ, BookmarkStart.b("戨挪怬", 3), LocaleIDs.km_KH, BookmarkStart.b("稨簪", 3), LocaleIDs.sw_KE, BookmarkStart.b("戨搪昬", 3), LocaleIDs.kok_IN, BookmarkStart.b("戨搪", 3), LocaleIDs.ko_KR, 
            BookmarkStart.b("戨爪", 3), LocaleIDs.ky_KG, BookmarkStart.b("攨横戬", 3), LocaleIDs.lo_LA, BookmarkStart.b("攨横", 3), LocaleIDs.la_Latn, BookmarkStart.b("攨紪", 3), LocaleIDs.lv_LV, BookmarkStart.b("攨缪", 3), LocaleIDs.lt_LT, BookmarkStart.b("ᤨἪᬬ樮", 3), LocaleIDs.lb_LU, BookmarkStart.b("搨怪", 3), LocaleIDs.mk_MK, BookmarkStart.b("搨砪", 3), LocaleIDs.ms_MY, 
            BookmarkStart.b("搨砪,洮缰", 3), LocaleIDs.ms_BN, BookmarkStart.b("搨未", 3), LocaleIDs.ml_IN, BookmarkStart.b("搨缪", 3), LocaleIDs.mt_MT, BookmarkStart.b("搨攪搬", 3), LocaleIDs.mni_IN, BookmarkStart.b("ᤨἪᔬḮ", 3), LocaleIDs.mi_NZ, BookmarkStart.b("ᤨἪᨬ渮", 3), LocaleIDs.arn_CL, BookmarkStart.b("搨礪", 3), LocaleIDs.mr_IN, BookmarkStart.b("ᤨἪᨬ氮", 3), LocaleIDs.moh_CA, 
            BookmarkStart.b("搨攪", 3), LocaleIDs.mn_MN, BookmarkStart.b("搨攪,戮缰", 3), LocaleIDs.mn_Mong_CN, BookmarkStart.b("木渪", 3), LocaleIDs.ne_NP, BookmarkStart.b("木渪,昮缰", 3), LocaleIDs.ne_IN, BookmarkStart.b("木搪,洮縰砲", 3), LocaleIDs.nb_NO, BookmarkStart.b("木搪,愮栰紲", 3), LocaleIDs.nn_NO, BookmarkStart.b("昨礪", 3), LocaleIDs.or_IN, BookmarkStart.b("昨昪", 3), LocaleIDs.om_Ethi_ET, 
            BookmarkStart.b("ᤨἪᨬᘮ", 3), LocaleIDs.pap_AN, BookmarkStart.b("ᤨἪᬬᰮ", 3), LocaleIDs.ps_AF, BookmarkStart.b("漨横", 3), LocaleIDs.fa_IR, BookmarkStart.b("礨未", 3), LocaleIDs.pl_PL, BookmarkStart.b("礨缪,洮挰", 3), LocaleIDs.pt_BR, BookmarkStart.b("礨缪", 3), LocaleIDs.pt_PT, BookmarkStart.b("礨横", 3), LocaleIDs.pa_IN, BookmarkStart.b("ᤨጪ᤬᤮", 3), LocaleIDs.pa_PK, 
            BookmarkStart.b("ᤨἪᬬ洮", 3), LocaleIDs.quz_BO, BookmarkStart.b("ᤨጪᬬ洮", 3), LocaleIDs.guz_EC, BookmarkStart.b("ᤨ株ᬬ洮", 3), LocaleIDs.guz_PE, BookmarkStart.b("笨搪,戮縰", 3), LocaleIDs.ro_MO, BookmarkStart.b("笨搪", 3), LocaleIDs.ro_RO, BookmarkStart.b("笨昪", 3), LocaleIDs.rm_CH, BookmarkStart.b("笨縪,戮縰", 3), LocaleIDs.ru_MO, BookmarkStart.b("笨縪", 3), LocaleIDs.ru_RU, 
            BookmarkStart.b("ᬨἪḬ洮", 3), LocaleIDs.smn_FI, BookmarkStart.b("ᠨᬪḬ洮", 3), LocaleIDs.smj_NO, BookmarkStart.b("ᠨἪḬ洮", 3), LocaleIDs.smj_SE, BookmarkStart.b("ᤨ株Ḭ洮", 3), LocaleIDs.se_FI, BookmarkStart.b("怨ت縬渮簰稲ᠴ礶瘸", 3), LocaleIDs.se_NO, BookmarkStart.b("ᤨጪḬ洮", 3), LocaleIDs.se_SE, BookmarkStart.b("ᬨᬪḬ洮", 3), LocaleIDs.sms_FI, BookmarkStart.b("ᠨጪḬ洮", 3), LocaleIDs.sma_NO, 
            BookmarkStart.b("ᠨ株Ḭ洮", 3), LocaleIDs.sma_SE, BookmarkStart.b("稨横", 3), LocaleIDs.sa_IN, BookmarkStart.b("ᤨἪᬬ氮", 3), LocaleIDs.nso_ZA, BookmarkStart.b("ᠨ株ᰬ渮", 3), LocaleIDs.sr_Cyrl_BA, BookmarkStart.b("稨礪,氮栰愲", 3), LocaleIDs.sr_Cyrl_CS, BookmarkStart.b("ᠨጪᰬ渮", 3), LocaleIDs.sr_Latn_BA, BookmarkStart.b("稨礪", 3), LocaleIDs.sr_Latn_CS, BookmarkStart.b("ᤨጪᠬᘮ", 3), LocaleIDs.sd_Arab_PK, 
            BookmarkStart.b("稨漪", 3), LocaleIDs.sd_Deva_IN, BookmarkStart.b("ᤨἪᠬ洮", 3), LocaleIDs.si_LK, BookmarkStart.b("稨怪", 3), LocaleIDs.sk_SK, BookmarkStart.b("稨未", 3), LocaleIDs.sl_SI, BookmarkStart.b("稨搪", 3), LocaleIDs.so_SO, BookmarkStart.b("稨椪", 3), LocaleIDs.hsb_DE, BookmarkStart.b("氨砪,渮挰", 3), LocaleIDs.es_AR, BookmarkStart.b("氨砪,洮縰", 3), LocaleIDs.es_BO, 
            BookmarkStart.b("氨砪,氮細", 3), LocaleIDs.es_CL, BookmarkStart.b("氨砪,氮縰", 3), LocaleIDs.es_CO, BookmarkStart.b("氨砪,氮挰", 3), LocaleIDs.es_CR, BookmarkStart.b("氨砪,欮縰", 3), LocaleIDs.es_DO, BookmarkStart.b("氨砪,樮爰", 3), LocaleIDs.es_EC, BookmarkStart.b("氨砪,簮朰", 3), LocaleIDs.es_SV, BookmarkStart.b("氨砪,栮攰", 3), LocaleIDs.es_GT, BookmarkStart.b("氨砪,朮缰", 3), LocaleIDs.es_HN, 
            BookmarkStart.b("氨砪,戮椰", 3), LocaleIDs.es_MX, BookmarkStart.b("氨砪,愮砰", 3), LocaleIDs.es_NI, BookmarkStart.b("氨砪,缮瀰", 3), LocaleIDs.es_PA, BookmarkStart.b("氨砪,缮栰", 3), LocaleIDs.es_PY, BookmarkStart.b("氨砪,缮琰", 3), LocaleIDs.es_PE, BookmarkStart.b("氨砪,缮挰", 3), LocaleIDs.es_PR, BookmarkStart.b("氨砪", 3), LocaleIDs.es_ES, BookmarkStart.b("氨砪,笮挰爲焴", 3), LocaleIDs.es_ES_tradnl, 
            BookmarkStart.b("氨砪,種栰", 3), LocaleIDs.es_UY, BookmarkStart.b("氨砪,礮琰", 3), LocaleIDs.es_VE, BookmarkStart.b("稨紪,椮砰", 3), LocaleIDs.sv_FI, BookmarkStart.b("稨紪", 3), LocaleIDs.sv_SE, BookmarkStart.b("稨爪缬", 3), LocaleIDs.syr_SY, BookmarkStart.b("紨氪", 3), LocaleIDs.tg_Cyrl_TJ, BookmarkStart.b("ᤨἪᠬ椮", 3), LocaleIDs.tzm_Arab_MA, BookmarkStart.b("ᤨጪᠬ椮", 3), LocaleIDs.tzm_Latn_DZ, 
            BookmarkStart.b("紨横", 3), LocaleIDs.ta_IN, BookmarkStart.b("紨缪", 3), LocaleIDs.tt_RU, BookmarkStart.b("紨渪", 3), LocaleIDs.te_IN, BookmarkStart.b("紨挪", 3), LocaleIDs.th_TH, BookmarkStart.b("ᤨጪᠬḮ", 3), LocaleIDs.bo_BT, BookmarkStart.b("欨搪", 3), LocaleIDs.bo_CN, BookmarkStart.b("紨截,樮挰", 3), LocaleIDs.ti_ER, BookmarkStart.b("紨截,樮攰", 3), LocaleIDs.ti_ET, 
            BookmarkStart.b("紨砪", 3), LocaleIDs.ts_ZA, BookmarkStart.b("紨攪", 3), LocaleIDs.tn_ZA, BookmarkStart.b("紨礪", 3), LocaleIDs.tr_TR, BookmarkStart.b("紨怪", 3), LocaleIDs.tk_TM, BookmarkStart.b("簨怪", 3), LocaleIDs.uk_UA, BookmarkStart.b("氨礪", 3), LocaleIDs.ur_PK, BookmarkStart.b("簨焪,氮栰愲", 3), LocaleIDs.uz_Cyrl_UZ, BookmarkStart.b("簨焪", 3), LocaleIDs.uz_Latn_UZ, 
            BookmarkStart.b("缨渪挬", 3), LocaleIDs.ve_ZA, BookmarkStart.b("缨截", 3), LocaleIDs.vi_VN, BookmarkStart.b("樨爪", 3), LocaleIDs.cy_GB, BookmarkStart.b("焨挪", 3), LocaleIDs.xh_ZA, BookmarkStart.b("ᤨἪᨬᜮ", 3), LocaleIDs.ii_CN, BookmarkStart.b("挨截", 3), LocaleIDs.yi_Hebr, BookmarkStart.b("瀨搪", 3), LocaleIDs.yo_NG, BookmarkStart.b("猨縪", 3), LocaleIDs.zu_ZA
         }, hashtable_2, hashtable_3);
        Class791.smethod_0(new object[] { 
            BookmarkStart.b("䠨䴪,甮瀰", 3), LocaleIDs.af_ZA, BookmarkStart.b("娨娪,渮細", 3), LocaleIDs.sq_AL, BookmarkStart.b("䠨䘪,樮攰", 3), LocaleIDs.am_ET, BookmarkStart.b("䠨太,欮欰", 3), LocaleIDs.ar_DZ, BookmarkStart.b("䠨太,洮礰", 3), LocaleIDs.ar_BH, BookmarkStart.b("䠨太,樮瘰", 3), LocaleIDs.ar_EG, BookmarkStart.b("䠨太,昮怰", 3), LocaleIDs.ar_IQ, BookmarkStart.b("䠨太,攮縰", 3), LocaleIDs.ar_JO, 
            BookmarkStart.b("䠨太,搮昰", 3), LocaleIDs.ar_KW, BookmarkStart.b("䠨太,挮猰", 3), LocaleIDs.ar_LB, BookmarkStart.b("䠨太,挮栰", 3), LocaleIDs.ar_LY, BookmarkStart.b("䠨太,戮瀰", 3), LocaleIDs.ar_MA, BookmarkStart.b("䠨太,怮簰", 3), LocaleIDs.ar_OM, BookmarkStart.b("䠨太,縮瀰", 3), LocaleIDs.ar_QA, BookmarkStart.b("䠨太,簮瀰", 3), LocaleIDs.ar_SA, BookmarkStart.b("䠨太,簮栰", 3), LocaleIDs.ar_SY, 
            BookmarkStart.b("䠨太,笮缰", 3), LocaleIDs.ar_TN, BookmarkStart.b("䠨太,渮琰", 3), LocaleIDs.ar_AE, BookmarkStart.b("䠨太,瘮琰", 3), LocaleIDs.ar_YE, BookmarkStart.b("䄨刪,渮簰", 3), LocaleIDs.hy_AM, BookmarkStart.b("䠨堪,昮缰", 3), LocaleIDs.as_IN, BookmarkStart.b("䠨優,氮䠰䄲头ᨶ砸愺", 3), LocaleIDs.az_Cyrl_AZ, BookmarkStart.b("䠨優,挮倰䜲嬴ᨶ砸愺", 3), LocaleIDs.az_Latn_AZ, BookmarkStart.b("䰨帪,樮戰", 3), LocaleIDs.eu_ES, 
            BookmarkStart.b("䬨个,洮栰", 3), LocaleIDs.be_BY, BookmarkStart.b("䬨䔪,昮缰", 3), LocaleIDs.bn_IN, BookmarkStart.b("䬨䔪,洮田", 3), LocaleIDs.bn_BD, BookmarkStart.b("䬨堪,氮䠰䄲头ᨶ笸稺", 3), LocaleIDs.bs_Cyrl_BA, BookmarkStart.b("䬨堪,挮倰䜲嬴ᨶ笸稺", 3), LocaleIDs.bs_Latn_BA, BookmarkStart.b("䬨䰪,洮瘰", 3), LocaleIDs.bg_BG, BookmarkStart.b("䐨刪,戮簰", 3), LocaleIDs.my_MM, BookmarkStart.b("䨨䨪,樮戰", 3), LocaleIDs.ca_ES, 
            BookmarkStart.b("䨨䌪弬Ȯ搰怲", 3), LocaleIDs.chr_US, BookmarkStart.b("匨䌪,朮稰", 3), LocaleIDs.zh_HK, BookmarkStart.b("匨䌪,戮縰", 3), LocaleIDs.zh_MO, BookmarkStart.b("匨䌪,氮缰", 3), LocaleIDs.zh_CN, BookmarkStart.b("匨䌪,簮瘰", 3), LocaleIDs.zh_SG, BookmarkStart.b("匨䌪,笮昰", 3), LocaleIDs.zh_TW, BookmarkStart.b("䄨太,洮瀰", 3), LocaleIDs.hr_BA, BookmarkStart.b("䄨太,朮挰", 3), LocaleIDs.hr_HR, 
            BookmarkStart.b("䨨堪,氮欰", 3), LocaleIDs.cs_CZ, BookmarkStart.b("䴨䨪,欮稰", 3), LocaleIDs.da_DK, BookmarkStart.b("䴨崪,戮朰", 3), LocaleIDs.dv_MV, BookmarkStart.b("䜨䜪,愮細", 3), LocaleIDs.nl_NL, BookmarkStart.b("䜨䜪,洮琰", 3), LocaleIDs.nl_BE, BookmarkStart.b("䬨䈪䌬Ȯ缰琲", 3), LocaleIDs.bin_NG, BookmarkStart.b("䰨䔪,渮搰", 3), LocaleIDs.en_AU, BookmarkStart.b("䰨䔪,洮欰", 3), LocaleIDs.en_BZ, 
            BookmarkStart.b("䰨䔪,氮瀰", 3), LocaleIDs.en_CA, BookmarkStart.b("䰨䔪,Ἦ̰ਲ", 3), LocaleIDs.en_029, BookmarkStart.b("䰨䔪,朮稰", 3), LocaleIDs.en_HK, BookmarkStart.b("䰨䔪,昮缰", 3), LocaleIDs.en_IN, BookmarkStart.b("䰨䔪,昮田", 3), LocaleIDs.en_ID, BookmarkStart.b("䰨䔪,昮琰", 3), LocaleIDs.en_IE, BookmarkStart.b("䰨䔪,攮簰", 3), LocaleIDs.en_JM, BookmarkStart.b("䰨䔪,戮栰", 3), LocaleIDs.en_MY, 
            BookmarkStart.b("䰨䔪,愮欰", 3), LocaleIDs.en_NZ, BookmarkStart.b("䰨䔪,缮礰", 3), LocaleIDs.en_PH, BookmarkStart.b("䰨䔪,簮瘰", 3), LocaleIDs.en_SG, BookmarkStart.b("䰨䔪,甮瀰", 3), LocaleIDs.en_ZA, BookmarkStart.b("䰨䔪,笮攰", 3), LocaleIDs.en_TT, BookmarkStart.b("䰨䔪,栮猰", 3), LocaleIDs.en_GB, BookmarkStart.b("䰨䔪,種戰", 3), LocaleIDs.en_US, BookmarkStart.b("䰨䔪,甮昰", 3), LocaleIDs.en_ZW, 
            BookmarkStart.b("䰨弪,樮琰", 3), LocaleIDs.et_EE, BookmarkStart.b("伨䐪,椮縰", 3), LocaleIDs.fo_FO, BookmarkStart.b("伨䈪䄬Ȯ愰笲", 3), LocaleIDs.fil_PH, BookmarkStart.b("伨䈪,椮砰", 3), LocaleIDs.fi_FI, BookmarkStart.b("伨太,洮琰", 3), LocaleIDs.fr_BE, BookmarkStart.b("伨太,氮簰", 3), LocaleIDs.fr_CM, BookmarkStart.b("伨太,氮瀰", 3), LocaleIDs.fr_CA, BookmarkStart.b("伨太,氮田", 3), LocaleIDs.fr_CD, 
            BookmarkStart.b("伨太,氮砰", 3), LocaleIDs.fr_CI, BookmarkStart.b("伨太,椮挰", 3), LocaleIDs.fr_FR, BookmarkStart.b("伨太,朮攰", 3), LocaleIDs.fr_HT, BookmarkStart.b("伨太,挮搰", 3), LocaleIDs.fr_LU, BookmarkStart.b("伨太,戮細", 3), LocaleIDs.fr_ML, BookmarkStart.b("伨太,戮爰", 3), LocaleIDs.fr_MC, BookmarkStart.b("伨太,戮瀰", 3), LocaleIDs.fr_MA, BookmarkStart.b("伨太,紮琰", 3), LocaleIDs.fr_RE, 
            BookmarkStart.b("伨太,簮缰", 3), LocaleIDs.fr_SN, BookmarkStart.b("伨太,氮礰", 3), LocaleIDs.fr_CH, BookmarkStart.b("伨太,砮砰紲焴縶簸栺", 3), LocaleIDs.fr_fr_WINDIES, BookmarkStart.b("伨刪,愮細", 3), LocaleIDs.fy_NL, BookmarkStart.b("伨䴪,愮瘰", 3), LocaleIDs.ff_NG, BookmarkStart.b("丨伪,栮猰", 3), LocaleIDs.gd_GB, BookmarkStart.b("丨䜪,樮戰", 3), LocaleIDs.gl_ES, BookmarkStart.b("䈨䨪,栮琰", 3), LocaleIDs.ka_GE, 
            BookmarkStart.b("䴨个,渮攰", 3), LocaleIDs.de_AT, BookmarkStart.b("䴨个,欮琰", 3), LocaleIDs.de_DE, BookmarkStart.b("䴨个,挮砰", 3), LocaleIDs.de_LI, BookmarkStart.b("䴨个,挮搰", 3), LocaleIDs.de_LU, BookmarkStart.b("䴨个,氮礰", 3), LocaleIDs.de_CH, BookmarkStart.b("䰨䜪,栮挰", 3), LocaleIDs.el_GR, BookmarkStart.b("丨䔪,缮栰", 3), LocaleIDs.gn_PY, BookmarkStart.b("丨帪,昮缰", 3), LocaleIDs.gu_IN, 
            BookmarkStart.b("䄨䨪,挮倰䜲嬴ᨶ眸簺", 3), LocaleIDs.ha_Latn_NG, BookmarkStart.b("䄨䨪娬Ȯ搰怲", 3), LocaleIDs.haw_US, BookmarkStart.b("䄨个,昮細", 3), LocaleIDs.he_IL, BookmarkStart.b("䄨䈪,昮缰", 3), LocaleIDs.hi_IN, BookmarkStart.b("䄨帪,朮搰", 3), LocaleIDs.hu_HU, BookmarkStart.b("䀨䤪伬Ȯ缰琲", 3), LocaleIDs.ibb_NG, BookmarkStart.b("䀨堪,昮戰", 3), LocaleIDs.is_IS, BookmarkStart.b("䀨䰪,愮瘰", 3), LocaleIDs.ig_NG, 
            BookmarkStart.b("䀨伪,昮田", 3), LocaleIDs.id_ID, BookmarkStart.b("䀨帪,氮倰崲䘴ᨶ稸稺", 3), LocaleIDs.iu_Cans_CA, BookmarkStart.b("䀨帪,挮倰䜲嬴ᨶ稸稺", 3), LocaleIDs.iu_Latn_CA, BookmarkStart.b("丨䨪,昮琰", 3), LocaleIDs.ga_IE, BookmarkStart.b("䀨弪,昮攰", 3), LocaleIDs.it_IT, BookmarkStart.b("䀨弪,氮礰", 3), LocaleIDs.it_CH, BookmarkStart.b("䌨䨪,攮愰", 3), LocaleIDs.ja_JP, BookmarkStart.b("䈨䔪,昮缰", 3), LocaleIDs.kn_IN, 
            BookmarkStart.b("䈨太,愮瘰", 3), LocaleIDs.kr_NG, BookmarkStart.b("䈨堪,欮吰䔲吴", 3), LocaleIDs.ks_Deva, BookmarkStart.b("䈨堪,渮䌰刲圴", 3), LocaleIDs.ks_Arab, BookmarkStart.b("䈨䀪,搮欰", 3), LocaleIDs.kk_KZ, BookmarkStart.b("䈨䘪,搮礰", 3), LocaleIDs.km_KH, BookmarkStart.b("娨尪,搮琰", 3), LocaleIDs.sw_KE, BookmarkStart.b("䈨䐪䘬Ȯ砰紲", 3), LocaleIDs.kok_IN, BookmarkStart.b("䈨䐪,搮挰", 3), LocaleIDs.ko_KR, 
            BookmarkStart.b("䈨刪,搮瘰", 3), LocaleIDs.ky_KG, BookmarkStart.b("䔨䐪,挮瀰", 3), LocaleIDs.lo_LA, BookmarkStart.b("䔨䨪,挮倰䜲嬴", 3), LocaleIDs.la_Latn, BookmarkStart.b("䔨崪,挮朰", 3), LocaleIDs.lv_LV, BookmarkStart.b("䔨弪,挮攰", 3), LocaleIDs.lt_LT, BookmarkStart.b("䔨䤪,挮搰", 3), LocaleIDs.lb_LU, BookmarkStart.b("䐨䀪,戮稰", 3), LocaleIDs.mk_MK, BookmarkStart.b("䐨堪,戮栰", 3), LocaleIDs.ms_MY, 
            BookmarkStart.b("䐨堪,洮缰", 3), LocaleIDs.ms_BN, BookmarkStart.b("䐨䜪,昮缰", 3), LocaleIDs.ml_IN, BookmarkStart.b("䐨弪,戮攰", 3), LocaleIDs.mt_MT, BookmarkStart.b("䐨䔪䐬Ȯ砰紲", 3), LocaleIDs.mni_IN, BookmarkStart.b("䐨䈪,愮欰", 3), LocaleIDs.mi_NZ, BookmarkStart.b("䠨太䌬Ȯ爰缲", 3), LocaleIDs.arn_CL, BookmarkStart.b("䐨太,昮缰", 3), LocaleIDs.mr_IN, BookmarkStart.b("䐨䐪䔬Ȯ爰爲", 3), LocaleIDs.moh_CA, 
            BookmarkStart.b("䐨䔪,戮缰", 3), LocaleIDs.mn_MN, BookmarkStart.b("䐨䔪,戮帰崲刴ᨶ稸町", 3), LocaleIDs.mn_Mong_CN, BookmarkStart.b("䜨个,愮愰", 3), LocaleIDs.ne_NP, BookmarkStart.b("䜨个,昮缰", 3), LocaleIDs.ne_IN, BookmarkStart.b("䜨䤪,愮縰", 3), LocaleIDs.nb_NO, BookmarkStart.b("䜨䔪,愮縰", 3), LocaleIDs.nn_NO, BookmarkStart.b("䘨太,昮缰", 3), LocaleIDs.or_IN, BookmarkStart.b("䘨䘪,樮䔰嬲尴ᨶ簸漺", 3), LocaleIDs.om_Ethi_ET, 
            BookmarkStart.b("夨䨪崬Ȯ瀰紲", 3), LocaleIDs.pap_AN, BookmarkStart.b("夨堪,渮眰", 3), LocaleIDs.ps_AF, BookmarkStart.b("伨䨪,昮挰", 3), LocaleIDs.fa_IR, BookmarkStart.b("夨䜪,缮細", 3), LocaleIDs.pl_PL, BookmarkStart.b("夨弪,洮挰", 3), LocaleIDs.pt_BR, BookmarkStart.b("夨弪,缮攰", 3), LocaleIDs.pt_PT, BookmarkStart.b("夨䨪,昮缰", 3), LocaleIDs.pa_IN, BookmarkStart.b("夨䨪,缮稰", 3), LocaleIDs.pa_PK, 
            BookmarkStart.b("堨帪圬Ȯ猰簲", 3), LocaleIDs.quz_BO, BookmarkStart.b("堨帪圬Ȯ琰瀲", 3), LocaleIDs.guz_EC, BookmarkStart.b("堨帪圬Ȯ愰瘲", 3), LocaleIDs.guz_PE, BookmarkStart.b("嬨䐪,戮縰", 3), LocaleIDs.ro_MO, BookmarkStart.b("嬨䐪,紮縰", 3), LocaleIDs.ro_RO, BookmarkStart.b("嬨䘪,氮礰", 3), LocaleIDs.rm_CH, BookmarkStart.b("嬨帪,戮縰", 3), LocaleIDs.ru_MO, BookmarkStart.b("嬨帪,紮搰", 3), LocaleIDs.ru_RU, 
            BookmarkStart.b("娨䘪䌬Ȯ眰稲", 3), LocaleIDs.smn_FI, BookmarkStart.b("娨䘪䜬Ȯ缰簲", 3), LocaleIDs.smj_NO, BookmarkStart.b("娨䘪䜬Ȯ戰瘲", 3), LocaleIDs.smj_SE, BookmarkStart.b("娨个,椮砰", 3), LocaleIDs.se_FI, BookmarkStart.b("娨个,愮縰", 3), LocaleIDs.se_NO, BookmarkStart.b("娨个,簮琰", 3), LocaleIDs.se_SE, BookmarkStart.b("娨䘪帬Ȯ眰稲", 3), LocaleIDs.sms_FI, BookmarkStart.b("娨䘪䰬Ȯ缰簲", 3), LocaleIDs.sma_NO, 
            BookmarkStart.b("娨䘪䰬Ȯ戰瘲", 3), LocaleIDs.sma_SE, BookmarkStart.b("娨䨪,昮缰", 3), LocaleIDs.sa_IN, BookmarkStart.b("䜨堪䈬Ȯ欰爲", 3), LocaleIDs.nso_ZA, BookmarkStart.b("娨太,氮䠰䄲头ᨶ笸稺", 3), LocaleIDs.sr_Cyrl_BA, BookmarkStart.b("娨太,氮䠰䄲头ᨶ稸栺", 3), LocaleIDs.sr_Cyrl_CS, BookmarkStart.b("娨太,挮倰䜲嬴ᨶ笸稺", 3), LocaleIDs.sr_Latn_BA, BookmarkStart.b("娨太,挮倰䜲嬴ᨶ稸栺", 3), LocaleIDs.sr_Latn_CS, BookmarkStart.b("娨伪,渮䌰刲圴ᨶ椸瀺", 3), LocaleIDs.sd_Arab_PK, 
            BookmarkStart.b("娨伪,欮吰䔲吴ᨶ瀸町", 3), LocaleIDs.sd_Deva_IN, BookmarkStart.b("娨䈪,挮稰", 3), LocaleIDs.si_LK, BookmarkStart.b("娨䀪,簮稰", 3), LocaleIDs.sk_SK, BookmarkStart.b("娨䜪,簮砰", 3), LocaleIDs.sl_SI, BookmarkStart.b("娨䐪,簮縰", 3), LocaleIDs.so_SO, BookmarkStart.b("䄨堪伬Ȯ田瘲", 3), LocaleIDs.hsb_DE, BookmarkStart.b("䰨堪,渮挰", 3), LocaleIDs.es_AR, BookmarkStart.b("䰨堪,洮縰", 3), LocaleIDs.es_BO, 
            BookmarkStart.b("䰨堪,氮細", 3), LocaleIDs.es_CL, BookmarkStart.b("䰨堪,氮縰", 3), LocaleIDs.es_CO, BookmarkStart.b("䰨堪,氮挰", 3), LocaleIDs.es_CR, BookmarkStart.b("䰨堪,欮縰", 3), LocaleIDs.es_DO, BookmarkStart.b("䰨堪,樮爰", 3), LocaleIDs.es_EC, BookmarkStart.b("䰨堪,簮朰", 3), LocaleIDs.es_SV, BookmarkStart.b("䰨堪,栮攰", 3), LocaleIDs.es_GT, BookmarkStart.b("䰨堪,朮缰", 3), LocaleIDs.es_HN, 
            BookmarkStart.b("䰨堪,戮椰", 3), LocaleIDs.es_MX, BookmarkStart.b("䰨堪,愮砰", 3), LocaleIDs.es_NI, BookmarkStart.b("䰨堪,缮瀰", 3), LocaleIDs.es_PA, BookmarkStart.b("䰨堪,缮栰", 3), LocaleIDs.es_PY, BookmarkStart.b("䰨堪,缮琰", 3), LocaleIDs.es_PE, BookmarkStart.b("䰨堪,缮挰", 3), LocaleIDs.es_PR, BookmarkStart.b("䰨堪,樮戰", 3), LocaleIDs.es_ES, BookmarkStart.b("䰨堪,樮戰氲䄴䔶堸强匼匾", 3), LocaleIDs.es_ES_tradnl, 
            BookmarkStart.b("䰨堪,種栰", 3), LocaleIDs.es_UY, BookmarkStart.b("䰨堪,礮琰", 3), LocaleIDs.es_VE, BookmarkStart.b("娨崪,椮砰", 3), LocaleIDs.sv_FI, BookmarkStart.b("娨崪,簮琰", 3), LocaleIDs.sv_SE, BookmarkStart.b("娨刪弬Ȯ戰樲", 3), LocaleIDs.syr_SY, BookmarkStart.b("崨䰪,氮䠰䄲头ᨶ洸焺", 3), LocaleIDs.tg_Cyrl_TJ, BookmarkStart.b("崨優䀬Ȯ瀰䄲吴唶ᐸ瘺簼", 3), LocaleIDs.tzm_Arab_MA, BookmarkStart.b("崨優䀬Ȯ細刲䄴夶ᐸ缺朼", 3), LocaleIDs.tzm_Latn_DZ, 
            BookmarkStart.b("崨䨪,昮缰", 3), LocaleIDs.ta_IN, BookmarkStart.b("崨弪,紮搰", 3), LocaleIDs.tt_RU, BookmarkStart.b("崨个,昮缰", 3), LocaleIDs.te_IN, BookmarkStart.b("崨䌪,笮礰", 3), LocaleIDs.th_TH, BookmarkStart.b("䬨䐪,洮攰", 3), LocaleIDs.bo_BT, BookmarkStart.b("䬨䐪,氮缰", 3), LocaleIDs.bo_CN, BookmarkStart.b("崨䈪,樮挰", 3), LocaleIDs.ti_ER, BookmarkStart.b("崨䈪,樮攰", 3), LocaleIDs.ti_ET, 
            BookmarkStart.b("崨堪,甮瀰", 3), LocaleIDs.ts_ZA, BookmarkStart.b("崨䔪,甮瀰", 3), LocaleIDs.tn_ZA, BookmarkStart.b("崨太,笮挰", 3), LocaleIDs.tr_TR, BookmarkStart.b("崨䀪,笮簰", 3), LocaleIDs.tk_TM, BookmarkStart.b("尨䀪,種瀰", 3), LocaleIDs.uk_UA, BookmarkStart.b("尨太,缮稰", 3), LocaleIDs.ur_PK, BookmarkStart.b("尨優,氮䠰䄲头ᨶ永愺", 3), LocaleIDs.uz_Cyrl_UZ, BookmarkStart.b("尨優,挮倰䜲嬴ᨶ永愺", 3), LocaleIDs.uz_Latn_UZ, 
            BookmarkStart.b("弨个,甮瀰", 3), LocaleIDs.ve_ZA, BookmarkStart.b("弨䈪,礮缰", 3), LocaleIDs.vi_VN, BookmarkStart.b("䨨刪,栮猰", 3), LocaleIDs.cy_GB, BookmarkStart.b("儨䌪,甮瀰", 3), LocaleIDs.xh_ZA, BookmarkStart.b("䀨䈪,氮缰", 3), LocaleIDs.ii_CN, BookmarkStart.b("倨䈪,朮吰儲䜴", 3), LocaleIDs.yi_Hebr, BookmarkStart.b("倨䐪,愮瘰", 3), LocaleIDs.yo_NG, BookmarkStart.b("匨帪,甮瀰", 3), LocaleIDs.zu_ZA
         }, hashtable_0, hashtable_1);
    }

    internal static int smethod_0(string A_0, bool A_1)
    {
        Hashtable hashtable = A_1 ? hashtable_0 : hashtable_2;
        return (int) Class791.smethod_3(hashtable, A_0, LocaleIDs.x_none);
    }

    internal static string smethod_1(int A_0, bool A_1)
    {
        Hashtable hashtable = A_1 ? hashtable_1 : hashtable_3;
        return (string) Class791.smethod_3(hashtable, (LocaleIDs) A_0, "");
    }

    internal static string smethod_10(CharacterCategory A_0, bool A_1)
    {
        int num = 8;
        switch (A_0)
        {
            case CharacterCategory.FarEast:
                if (A_1)
                {
                    return BookmarkStart.b("䬭儯䄱䀳眵䬷匹崻", num);
                }
                return BookmarkStart.b("䠭儯䀱儳圵䬷丹", num);

            case CharacterCategory.ComplexScript:
                return BookmarkStart.b("䴭䌯", num);
        }
        return BookmarkStart.b("䨭唯吱唳䌵吷丹", num);
    }

    internal static LineBreakClear smethod_11(string A_0)
    {
        int num = 4;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䐩䌫䀭唯", num))
            {
                return LineBreakClear.None;
            }
            if (str == BookmarkStart.b("䘩䤫䠭䐯", num))
            {
                return LineBreakClear.Left;
            }
            if (str == BookmarkStart.b("堩䔫䤭堯䘱", num))
            {
                return LineBreakClear.Right;
            }
            if (str == BookmarkStart.b("䬩䀫䈭", num))
            {
                return LineBreakClear.All;
            }
        }
        return LineBreakClear.None;
    }

    internal static string smethod_12(LineBreakClear A_0)
    {
        int num = 12;
        switch (A_0)
        {
            case LineBreakClear.None:
                return BookmarkStart.b("就嬳堵崷", num);

            case LineBreakClear.Left:
                return BookmarkStart.b("帱儳倵䰷", num);

            case LineBreakClear.Right:
                return BookmarkStart.b("䀱崳儵倷丹", num);

            case LineBreakClear.All:
                return BookmarkStart.b("匱堳娵", num);
        }
        return "";
    }

    internal static BreakType smethod_13(string A_0)
    {
        int num = 9;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("弮倰吲倴", num))
            {
                return BreakType.PageBreak;
            }
            if (str == BookmarkStart.b("䰮帰弲䀴娶圸", num))
            {
                return BreakType.ColumnBreak;
            }
            if ((str == BookmarkStart.b("嬮吰䬲䄴怶䬸娺䴼伾⡀ⵂ≄", num)) || (str == BookmarkStart.b("嬮吰䬲䄴ᨶ丸䤺尼伾ㅀ⩂⭄⁆", num)))
            {
            }
        }
        return BreakType.LineBreak;
    }

    internal static string smethod_14(BreakType A_0, bool A_1)
    {
        int num = 8;
        switch (A_0)
        {
            case BreakType.PageBreak:
                return BookmarkStart.b("席儯唱儳", num);

            case BreakType.ColumnBreak:
                return BookmarkStart.b("䴭弯帱䄳嬵嘷", num);

            case BreakType.LineBreak:
                if (A_1)
                {
                    return BookmarkStart.b("娭唯䨱䀳愵䨷嬹䰻丽⤿ⱁ⍃", num);
                }
                return BookmarkStart.b("娭唯䨱䀳ᬵ伷䠹崻丽〿⭁⩃ⅅ", num);
        }
        return "";
    }

    internal static TextEffect smethod_15(string A_0)
    {
        int num = 12;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_176 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                dictionary1.Add(BookmarkStart.b("倱堳張嘷儹縻弽⌿⥁⍃㑅❇㽉≋⩍", num), 0);
                dictionary1.Add(BookmarkStart.b("倱堳張嘷儹ᄻ尽ℿ⅁⽃ⅅ㩇╉㥋⁍㑏", num), 1);
                dictionary1.Add(BookmarkStart.b("帱崳儵倷丹伻", num), 2);
                dictionary1.Add(BookmarkStart.b("匱娳䈵䬷砹倻弽⌿⥁", num), 3);
                dictionary1.Add(BookmarkStart.b("匱娳䈵䬷᜹帻刽ℿ⅁⽃", num), 4);
                dictionary1.Add(BookmarkStart.b("匱娳䈵䬷根夻娽", num), 5);
                dictionary1.Add(BookmarkStart.b("匱娳䈵䬷᜹主嬽␿", num), 6);
                dictionary1.Add(BookmarkStart.b("䄱尳張唷圹夻䰽", num), 7);
                dictionary1.Add(BookmarkStart.b("䄱䐳圵䨷儹倻嬽", num), 8);
                dictionary1.Add(BookmarkStart.b("就嬳堵崷", num), 9);
                Class1160.dictionary_176 = dictionary1;
            }
            if (Class1160.dictionary_176.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                        return TextEffect.BlinkingBackground;

                    case 2:
                        return TextEffect.LasVegasLights;

                    case 3:
                    case 4:
                        return TextEffect.MarchingBlackAnts;

                    case 5:
                    case 6:
                        return TextEffect.MarchingRedAnts;

                    case 7:
                        return TextEffect.Shimmer;

                    case 8:
                        return TextEffect.SparkleText;
                }
            }
        }
        return TextEffect.None;
    }

    internal static string smethod_16(TextEffect A_0, bool A_1)
    {
        int num = 9;
        switch (A_0)
        {
            case TextEffect.LasVegasLights:
                return BookmarkStart.b("䌮堰吲崴䌶䨸", num);

            case TextEffect.BlinkingBackground:
                if (A_1)
                {
                    return BookmarkStart.b("䴮崰娲嬴尶笸娺帼吾♀ㅂ⩄㉆❈⽊", num);
                }
                return BookmarkStart.b("䴮崰娲嬴尶ᐸ夺尼尾⩀⑂㝄⡆㱈╊⥌", num);

            case TextEffect.SparkleText:
                return BookmarkStart.b("尮䄰刲䜴尶唸帺", num);

            case TextEffect.MarchingBlackAnts:
                if (A_1)
                {
                    return BookmarkStart.b("丮弰䜲䘴甶唸娺帼吾", num);
                }
                return BookmarkStart.b("丮弰䜲䘴ᨶ嬸场尼尾⩀", num);

            case TextEffect.MarchingRedAnts:
                if (A_1)
                {
                    return BookmarkStart.b("丮弰䜲䘴收尸强", num);
                }
                return BookmarkStart.b("丮弰䜲䘴ᨶ䬸帺夼", num);

            case TextEffect.Shimmer:
                return BookmarkStart.b("尮夰娲場娶尸䤺", num);
        }
        return BookmarkStart.b("䄮帰崲倴", num);
    }

    internal static UnderlineStyle smethod_17(string A_0)
    {
        int num = 0x11;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_177 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x1c);
                dictionary1.Add(BookmarkStart.b("䐶倸唺娼匾⑀", num), 0);
                dictionary1.Add(BookmarkStart.b("䀶嘸䤺夼䰾", num), 1);
                dictionary1.Add(BookmarkStart.b("匶嘸为弼匾⑀", num), 2);
                dictionary1.Add(BookmarkStart.b("䌶儸刺帼吾", num), 3);
                dictionary1.Add(BookmarkStart.b("匶嘸伺䤼娾╀", num), 4);
                dictionary1.Add(BookmarkStart.b("匶嘸伺䤼娾╀湂ⵄ≆⡈㵊㑌", num), 5);
                dictionary1.Add(BookmarkStart.b("匶嘸伺䤼娾╀ୂ⁄♆㽈㉊", num), 6);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼", num), 7);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼娾╀湂ⵄ≆⡈㵊㑌", num), 8);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼娾╀ୂ⁄♆㽈㉊", num), 9);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼ሾⵀⱂ⭄⁆", num), 10);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼猾⹀ⵂ≄", num), 11);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼ሾⵀⱂ⭄⁆摈⍊⡌⹎❐⩒", num), 12);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼猾⹀ⵂ≄ཆⱈ⩊㭌㙎", num), 13);
                dictionary1.Add(BookmarkStart.b("匶嘸伺ြ嬾⁀あⵄ", num), 14);
                dictionary1.Add(BookmarkStart.b("匶嘸伺礼帾㉀⭂", num), 15);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼ሾ╀ⱂㅄ橆ⅈ⹊ⱌ㥎⡐", num), 0x10);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼笾⹀㝂ൄ≆⡈㵊㑌", num), 0x11);
                dictionary1.Add(BookmarkStart.b("匶嘸伺ြ嬾⹀㝂桄⍆⡈㡊╌", num), 0x12);
                dictionary1.Add(BookmarkStart.b("匶嘸伺礼倾㕀݂⑄㑆ⅈ", num), 0x13);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼ሾ╀ⱂㅄ橆ⵈ⑊㥌扎㥐㙒㑔⅖⁘", num), 20);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼笾⹀㝂ń⡆㵈͊⡌⹎❐⩒", num), 0x15);
                dictionary1.Add(BookmarkStart.b("䀶堸䴺堼", num), 0x16);
                dictionary1.Add(BookmarkStart.b("䀶堸䴺䐼ሾ⥀♂⑄ㅆえ", num), 0x17);
                dictionary1.Add(BookmarkStart.b("䀶堸䴺䐼眾⑀≂㍄㹆", num), 0x18);
                dictionary1.Add(BookmarkStart.b("䀶堸䴺䐼ሾ╀ⱂい╆╈⹊", num), 0x19);
                dictionary1.Add(BookmarkStart.b("䀶堸䴺䐼笾⹀㙂❄⭆ⱈ", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("夶嘸唺堼", num), 0x1b);
                Class1160.dictionary_177 = dictionary1;
            }
            if (Class1160.dictionary_177.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return UnderlineStyle.Single;

                    case 1:
                        return UnderlineStyle.Words;

                    case 2:
                        return UnderlineStyle.Double;

                    case 3:
                        return UnderlineStyle.Thick;

                    case 4:
                        return UnderlineStyle.Dotted;

                    case 5:
                    case 6:
                        return UnderlineStyle.DottedHeavy;

                    case 7:
                        return UnderlineStyle.Dash;

                    case 8:
                    case 9:
                        return UnderlineStyle.DashHeavy;

                    case 10:
                    case 11:
                        return UnderlineStyle.DashLong;

                    case 12:
                    case 13:
                        return UnderlineStyle.DashLongHeavy;

                    case 14:
                    case 15:
                        return UnderlineStyle.DotDash;

                    case 0x10:
                    case 0x11:
                        return UnderlineStyle.DotDashHeavy;

                    case 0x12:
                    case 0x13:
                        return UnderlineStyle.DotDotDash;

                    case 20:
                    case 0x15:
                        return UnderlineStyle.DotDotDashHeavy;

                    case 0x16:
                        return UnderlineStyle.Wavy;

                    case 0x17:
                    case 0x18:
                        return UnderlineStyle.WavyHeavy;

                    case 0x19:
                    case 0x1a:
                        return UnderlineStyle.WavyDouble;
                }
            }
        }
        return UnderlineStyle.None;
    }

    internal static string smethod_18(UnderlineStyle A_0, bool A_1)
    {
        int num = 5;
        switch (A_0)
        {
            case UnderlineStyle.Single:
                return BookmarkStart.b("堪䐬䄮嘰弲倴", num);

            case UnderlineStyle.Words:
                return BookmarkStart.b("尪䈬崮唰䀲", num);

            case UnderlineStyle.Double:
                return BookmarkStart.b("伪䈬娮匰弲倴", num);

            case UnderlineStyle.Dotted:
                return BookmarkStart.b("伪䈬嬮䔰嘲儴", num);

            case UnderlineStyle.Thick:
                return BookmarkStart.b("弪䔬䘮到堲", num);

            case UnderlineStyle.Dash:
                return BookmarkStart.b("伪䰬尮夰", num);

            case UnderlineStyle.DotDash:
                if (A_1)
                {
                    return BookmarkStart.b("伪䈬嬮田刲䘴弶", num);
                }
                return BookmarkStart.b("伪䈬嬮ᰰ圲吴䐶儸", num);

            case UnderlineStyle.DotDotDash:
                if (A_1)
                {
                    return BookmarkStart.b("伪䈬嬮田尲䄴猶堸䠺唼", num);
                }
                return BookmarkStart.b("伪䈬嬮ᰰ圲娴䌶ᐸ强尼䰾⥀", num);

            case UnderlineStyle.Wavy:
                return BookmarkStart.b("尪䰬央吰", num);

            case UnderlineStyle.DottedHeavy:
                if (A_1)
                {
                    return BookmarkStart.b("伪䈬嬮䔰嘲儴缶尸娺䬼䘾", num);
                }
                return BookmarkStart.b("伪䈬嬮䔰嘲儴ᨶ儸帺尼䤾㡀", num);

            case UnderlineStyle.DashHeavy:
                if (A_1)
                {
                    return BookmarkStart.b("伪䰬尮夰嘲儴缶尸娺䬼䘾", num);
                }
                return BookmarkStart.b("伪䰬尮夰嘲儴ᨶ儸帺尼䤾㡀", num);

            case UnderlineStyle.DotDashHeavy:
                if (A_1)
                {
                    return BookmarkStart.b("伪䰬尮夰眲娴䌶焸帺尼䤾㡀", num);
                }
                return BookmarkStart.b("伪䰬尮夰Ḳ儴堶䴸ᘺ唼娾⁀㕂㱄", num);

            case UnderlineStyle.DotDotDashHeavy:
                if (A_1)
                {
                    return BookmarkStart.b("伪䰬尮夰眲娴䌶紸吺䤼眾⑀≂㍄㹆", num);
                }
                return BookmarkStart.b("伪䰬尮夰Ḳ儴堶䴸ᘺ夼倾㕀湂ⵄ≆⡈㵊㑌", num);

            case UnderlineStyle.WavyHeavy:
                if (A_1)
                {
                    return BookmarkStart.b("尪䰬央䠰笲倴嘶伸䈺", num);
                }
                return BookmarkStart.b("尪䰬央䠰Ḳ崴制堸䴺䐼", num);

            case UnderlineStyle.DashLong:
                if (!A_1)
                {
                    return BookmarkStart.b("伪䰬尮夰Ḳ头堶圸尺", num);
                }
                return BookmarkStart.b("伪䰬尮夰缲娴夶常", num);

            case UnderlineStyle.WavyDouble:
                if (!A_1)
                {
                    return BookmarkStart.b("尪䰬央䠰Ḳ儴堶䰸夺儼娾", num);
                }
                return BookmarkStart.b("尪䰬央䠰眲娴䈶嬸场堼", num);

            case UnderlineStyle.DashLongHeavy:
                if (!A_1)
                {
                    return BookmarkStart.b("伪䰬尮夰Ḳ头堶圸尺ြ圾⑀≂㍄㹆", num);
                }
                return BookmarkStart.b("伪䰬尮夰缲娴夶常猺堼帾㝀㩂", num);
        }
        return BookmarkStart.b("䔪䈬䄮吰", num);
    }

    internal static Color smethod_19(string A_0)
    {
        int num = 2;
        Color empty = Color.Empty;
        string key = A_0.ToLower();
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_178 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x1a);
                dictionary1.Add(BookmarkStart.b("䘧䔩䈫䬭", num), 0);
                dictionary1.Add(BookmarkStart.b("弧䈩䔫娭唯", num), 1);
                dictionary1.Add(BookmarkStart.b("儧伩䀫䈭弯䔱", num), 2);
                dictionary1.Add(BookmarkStart.b("伧堩䤫䬭帯", num), 3);
                dictionary1.Add(BookmarkStart.b("䬧匩䴫䀭", num), 4);
                dictionary1.Add(BookmarkStart.b("䔧䬩䬫䬭帯䘱唳", num), 5);
                dictionary1.Add(BookmarkStart.b("䨧䘩夫䬭", num), 6);
                dictionary1.Add(BookmarkStart.b("娧伩䠫", num), 7);
                dictionary1.Add(BookmarkStart.b("䰧䬩師䔭爯帱䄳匵", num), 8);
                dictionary1.Add(BookmarkStart.b("䰧䬩師䔭ᴯ倱堳䌵崷", num), 9);
                dictionary1.Add(BookmarkStart.b("䰧䬩師䔭猯䬱唳堵", num), 10);
                dictionary1.Add(BookmarkStart.b("䰧䬩師䔭ᴯ儱䴳圵嘷", num), 11);
                dictionary1.Add(BookmarkStart.b("䰧䬩師䔭眯䀱儳匵嘷", num), 12);
                dictionary1.Add(BookmarkStart.b("䰧䬩師䔭ᴯ唱䘳匵崷吹", num), 13);
                dictionary1.Add(BookmarkStart.b("䰧䬩師䔭累匱匳匵嘷丹崻", num), 14);
                dictionary1.Add(BookmarkStart.b("䰧䬩師䔭ᴯ弱唳儵崷吹䠻弽", num), 15);
                dictionary1.Add(BookmarkStart.b("䰧䬩師䔭戯圱倳", num), 0x10);
                dictionary1.Add(BookmarkStart.b("䰧䬩師䔭ᴯ䀱儳刵", num), 0x11);
                dictionary1.Add(BookmarkStart.b("䰧䬩師䔭椯圱堳娵圷䴹", num), 0x12);
                dictionary1.Add(BookmarkStart.b("䰧䬩師䔭ᴯ䬱儳娵吷唹䬻", num), 0x13);
                dictionary1.Add(BookmarkStart.b("䰧䬩師䔭眯䀱唳伵", num), 20);
                dictionary1.Add(BookmarkStart.b("䰧䬩師䔭ᴯ唱䘳圵䄷", num), 0x15);
                dictionary1.Add(BookmarkStart.b("䐧䌩䬫䘭䐯由䘳圵䄷", num), 0x16);
                dictionary1.Add(BookmarkStart.b("䐧䌩䬫䘭䐯ἱ匳䐵夷䌹", num), 0x17);
                dictionary1.Add(BookmarkStart.b("䤧弩堫䄭", num), 0x18);
                dictionary1.Add(BookmarkStart.b("䨧䘩䴫䴭嬯", num), 0x19);
                Class1160.dictionary_178 = dictionary1;
            }
            if (Class1160.dictionary_178.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return Color.Empty;

                    case 1:
                        return Color.White;

                    case 2:
                        return Color.Yellow;

                    case 3:
                        return Color.Green;

                    case 4:
                        return Color.Cyan;

                    case 5:
                        return Color.Magenta;

                    case 6:
                        return Color.Blue;

                    case 7:
                        return Color.Red;

                    case 8:
                    case 9:
                        return Color.DarkBlue;

                    case 10:
                    case 11:
                        return Color.DarkCyan;

                    case 12:
                    case 13:
                        return Color.DarkGreen;

                    case 14:
                    case 15:
                        return Color.DarkMagenta;

                    case 0x10:
                    case 0x11:
                        return Color.DarkRed;

                    case 0x12:
                    case 0x13:
                        return Color.Gold;

                    case 20:
                    case 0x15:
                        return Color.DarkGray;

                    case 0x16:
                    case 0x17:
                        return Color.LightGray;

                    case 0x18:
                    case 0x19:
                        return Color.Black;
                }
            }
        }
        return empty;
    }

    internal static string smethod_2(int A_0, bool A_1, bool A_2)
    {
        int num = 11;
        if ((A_0 == 0x400) && !A_1)
        {
            if (!A_2)
            {
                return BookmarkStart.b("琰紲ᠴ戶樸", num);
            }
            return BookmarkStart.b("吰崲ᠴ戶樸", num);
        }
        Hashtable hashtable = A_2 ? hashtable_1 : hashtable_3;
        return (string) Class791.smethod_3(hashtable, (LocaleIDs) A_0, "");
    }

    internal static string smethod_20(Color A_0, bool A_1)
    {
        int num = 10;
        switch (Class1006.smethod_20(A_0))
        {
            case OfficeColor.Auto:
                return BookmarkStart.b("帯崱娳匵", num);

            case OfficeColor.Black:
                return BookmarkStart.b("刯帱唳唵匷", num);

            case OfficeColor.Blue:
                return BookmarkStart.b("刯帱䄳匵", num);

            case OfficeColor.Cyan:
                return BookmarkStart.b("匯䬱唳堵", num);

            case OfficeColor.Green:
                return BookmarkStart.b("圯䀱儳匵嘷", num);

            case OfficeColor.Magenta:
                return BookmarkStart.b("崯匱匳匵嘷丹崻", num);

            case OfficeColor.Red:
                return BookmarkStart.b("䈯圱倳", num);

            case OfficeColor.Yellow:
                return BookmarkStart.b("䤯圱堳娵圷䴹", num);

            case OfficeColor.White:
                return BookmarkStart.b("䜯娱崳䈵崷", num);

            case OfficeColor.DarkBlue:
                if (A_1)
                {
                    return BookmarkStart.b("启匱䘳崵稷嘹䤻嬽", num);
                }
                return BookmarkStart.b("启匱䘳崵ᔷ堹倻䬽┿", num);

            case OfficeColor.DarkCyan:
                if (A_1)
                {
                    return BookmarkStart.b("启匱䘳崵笷䌹崻倽", num);
                }
                return BookmarkStart.b("启匱䘳崵ᔷ夹䔻弽⸿", num);

            case OfficeColor.DarkGreen:
                if (A_1)
                {
                    return BookmarkStart.b("启匱䘳崵缷䠹夻嬽⸿", num);
                }
                return BookmarkStart.b("启匱䘳崵ᔷ崹主嬽┿ⱁ", num);

            case OfficeColor.DarkMagenta:
                if (A_1)
                {
                    return BookmarkStart.b("启匱䘳崵男嬹嬻嬽⸿㙁╃", num);
                }
                return BookmarkStart.b("启匱䘳崵ᔷ圹崻夽┿ⱁぃ❅", num);

            case OfficeColor.DarkRed:
                if (A_1)
                {
                    return BookmarkStart.b("启匱䘳崵樷弹堻", num);
                }
                return BookmarkStart.b("启匱䘳崵ᔷ䠹夻娽", num);

            case OfficeColor.DarkYellow:
                if (A_1)
                {
                    return BookmarkStart.b("启匱䘳崵愷弹倻刽⼿㕁", num);
                }
                return BookmarkStart.b("启匱䘳崵ᔷ䌹夻刽ⰿⵁ㍃", num);

            case OfficeColor.DarkGray:
                if (A_1)
                {
                    return BookmarkStart.b("启匱䘳崵缷䠹崻䜽", num);
                }
                return BookmarkStart.b("启匱䘳崵ᔷ崹主弽㤿", num);

            case OfficeColor.LightGray:
                if (A_1)
                {
                    return BookmarkStart.b("尯嬱匳帵䰷紹主弽㤿", num);
                }
                return BookmarkStart.b("尯嬱匳帵䰷᜹嬻䰽ℿ㭁", num);
        }
        return BookmarkStart.b("帯崱娳匵", num);
    }

    internal static SubSuperScript smethod_21(string A_0)
    {
        int num = 0;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䐥䤧天䤫䈭夯就儳", num))
            {
                return SubSuperScript.None;
            }
            if (str == BookmarkStart.b("唥崧娩䤫尭䌯儱䘳張䠷丹", num))
            {
                return SubSuperScript.SuperScript;
            }
            if (str == BookmarkStart.b("唥崧䠩弫䴭䈯嬱䐳䈵", num))
            {
                return SubSuperScript.SubScript;
            }
        }
        return SubSuperScript.None;
    }

    internal static string smethod_22(SubSuperScript A_0)
    {
        int num = 0x13;
        switch (A_0)
        {
            case SubSuperScript.None:
                return BookmarkStart.b("嬸娺丼娾ⵀ⩂⭄≆", num);

            case SubSuperScript.SuperScript:
                return BookmarkStart.b("䨸为䴼娾㍀あ♄㕆⁈㭊㥌", num);

            case SubSuperScript.SubScript:
                return BookmarkStart.b("䨸为弼䰾≀ㅂⱄ㝆㵈", num);
        }
        return BookmarkStart.b("嬸娺丼娾ⵀ⩂⭄≆", num);
    }

    internal static HyphenRule smethod_23(string A_0)
    {
        int num = 9;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_179 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("䄮帰崲倴", num), 0);
                dictionary1.Add(BookmarkStart.b("䄮帰䄲場嘶唸", num), 1);
                dictionary1.Add(BookmarkStart.b("丮唰圲ᠴ唶尸崺刼䴾⑀", num), 2);
                dictionary1.Add(BookmarkStart.b("䰮夰刲嬴倶尸ᘺ弼娾❀ⱂ㝄≆", num), 3);
                dictionary1.Add(BookmarkStart.b("䬮吰弲倴䌶尸ᘺ弼娾❀ⱂ㝄≆", num), 4);
                dictionary1.Add(BookmarkStart.b("䰮夰刲嬴倶尸ᘺ尼夾㕀♂㝄", num), 5);
                dictionary1.Add(BookmarkStart.b("䬮吰弲倴䌶尸ᘺ尼儾╀湂♄⽆⡈╊⩌⩎", num), 6);
                Class1160.dictionary_179 = dictionary1;
            }
            if (Class1160.dictionary_179.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return HyphenRule.None;

                    case 1:
                        return HyphenRule.Normal;

                    case 2:
                        return HyphenRule.AddBefore;

                    case 3:
                        return HyphenRule.ChangeBefore;

                    case 4:
                        return HyphenRule.DeleteBefore;

                    case 5:
                        return HyphenRule.ChangeAfter;

                    case 6:
                        return HyphenRule.DeleteAndChange;
                }
            }
        }
        return HyphenRule.None;
    }

    internal static string smethod_24(HyphenRule A_0)
    {
        int num = 14;
        switch (A_0)
        {
            case HyphenRule.None:
                return BookmarkStart.b("娳夵嘷弹", num);

            case HyphenRule.Normal:
                return BookmarkStart.b("娳夵䨷圹崻刽", num);

            case HyphenRule.AddBefore:
                return BookmarkStart.b("唳刵尷᜹帻嬽☿ⵁ㙃⍅", num);

            case HyphenRule.ChangeBefore:
                return BookmarkStart.b("圳帵夷吹嬻嬽洿⁁⅃⁅❇㡉⥋", num);

            case HyphenRule.DeleteBefore:
                return BookmarkStart.b("倳匵吷弹䠻嬽洿⁁⅃⁅❇㡉⥋", num);

            case HyphenRule.ChangeAfter:
                return BookmarkStart.b("圳帵夷吹嬻嬽洿⍁≃㉅ⵇ㡉", num);

            case HyphenRule.DeleteAndChange:
                return BookmarkStart.b("倳匵吷弹䠻嬽洿⍁⩃≅敇⥉⑋⽍㹏㕑ㅓ", num);
        }
        return BookmarkStart.b("娳夵嘷弹", num);
    }

    internal static Emphasis smethod_3(string A_0)
    {
        int num = 14;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("圳張䨷夹倻嬽", num))
            {
                return Emphasis.CircleAbove;
            }
            if (str == BookmarkStart.b("圳夵唷圹崻", num))
            {
                return Emphasis.CommaAbove;
            }
            if (str == BookmarkStart.b("倳夵䰷", num))
            {
                return Emphasis.Dot;
            }
            if ((str == BookmarkStart.b("䄳堵尷弹主稽⼿㙁", num)) || (str == BookmarkStart.b("䄳堵尷弹主ጽ␿ⵁぃ", num)))
            {
                return Emphasis.DotBelow;
            }
        }
        return Emphasis.None;
    }

    internal static string smethod_4(Emphasis A_0, bool A_1)
    {
        int num = 0x10;
        switch (A_0)
        {
            case Emphasis.Dot:
                return BookmarkStart.b("刵圷丹", num);

            case Emphasis.CommaAbove:
                return BookmarkStart.b("唵圷圹儻弽", num);

            case Emphasis.CircleAbove:
                return BookmarkStart.b("唵儷䠹弻刽┿", num);

            case Emphasis.DotBelow:
                if (A_1)
                {
                    return BookmarkStart.b("䌵嘷帹夻䰽пⵁぃ", num);
                }
                return BookmarkStart.b("䌵嘷帹夻䰽洿♁⭃㉅", num);
        }
        return "";
    }

    internal static CombineBrackets smethod_5(string A_0)
    {
        int num = 14;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䘳夵䴷吹堻", num))
            {
                return CombineBrackets.Round;
            }
            if (str == BookmarkStart.b("唳堵強嘹夻", num))
            {
                return CombineBrackets.Angle;
            }
            if (str == BookmarkStart.b("䜳䜵䴷嬹主嬽", num))
            {
                return CombineBrackets.Square;
            }
            if (str == BookmarkStart.b("圳䌵䨷嘹䔻", num))
            {
                return CombineBrackets.Curly;
            }
        }
        return CombineBrackets.None;
    }

    internal static string smethod_6(CombineBrackets A_0)
    {
        int num = 2;
        switch (A_0)
        {
            case CombineBrackets.Round:
                return BookmarkStart.b("娧䔩夫䀭启", num);

            case CombineBrackets.Square:
                return BookmarkStart.b("嬧嬩夫伭䈯圱", num);

            case CombineBrackets.Angle:
                return BookmarkStart.b("䤧䐩䬫䈭唯", num);

            case CombineBrackets.Curly:
                return BookmarkStart.b("䬧弩師䈭䤯", num);
        }
        return "";
    }

    internal static ThemeFontTypes smethod_7(string A_0)
    {
        int num = 0x10;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_175 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(8);
                dictionary1.Add(BookmarkStart.b("嬵夷倹医䰽Ŀㅁ❃⽅ⅇ", num), 0);
                dictionary1.Add(BookmarkStart.b("嬵夷倹医䰽ȿ⭁⁃⽅", num), 1);
                dictionary1.Add(BookmarkStart.b("嬵夷倹医䰽Կ⍁㝃㉅े㥉╋⽍", num), 2);
                dictionary1.Add(BookmarkStart.b("嬵夷倹医䰽࠿́⩃㕅ⅇ", num), 3);
                dictionary1.Add(BookmarkStart.b("嬵儷吹医䰽Ŀㅁ❃⽅ⅇ", num), 4);
                dictionary1.Add(BookmarkStart.b("嬵儷吹医䰽ȿ⭁⁃⽅", num), 5);
                dictionary1.Add(BookmarkStart.b("嬵儷吹医䰽Կ⍁㝃㉅े㥉╋⽍", num), 6);
                dictionary1.Add(BookmarkStart.b("嬵儷吹医䰽࠿́⩃㕅ⅇ", num), 7);
                Class1160.dictionary_175 = dictionary1;
            }
            if (Class1160.dictionary_175.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return ThemeFontTypes.MajorAscii;

                    case 1:
                        return ThemeFontTypes.MajorBidi;

                    case 2:
                        return ThemeFontTypes.MajorEastAsia;

                    case 3:
                        return ThemeFontTypes.MajorHAnsi;

                    case 4:
                        return ThemeFontTypes.MinorAscii;

                    case 5:
                        return ThemeFontTypes.MinorBidi;

                    case 6:
                        return ThemeFontTypes.MinorEastAsia;

                    case 7:
                        return ThemeFontTypes.MinorHAnsi;
                }
            }
        }
        return ThemeFontTypes.None;
    }

    internal static string smethod_8(ThemeFontTypes A_0)
    {
        int num = 4;
        switch (A_0)
        {
            case ThemeFontTypes.MajorAscii:
                return BookmarkStart.b("䜩䴫䐭弯䀱申䔵嬷匹唻", num);

            case ThemeFontTypes.MajorBidi:
                return BookmarkStart.b("䜩䴫䐭弯䀱瘳張尷匹", num);

            case ThemeFontTypes.MajorEastAsia:
                return BookmarkStart.b("䜩䴫䐭弯䀱焳圵䬷丹紻䴽⤿⍁", num);

            case ThemeFontTypes.MajorHAnsi:
                return BookmarkStart.b("䜩䴫䐭弯䀱簳眵嘷䤹唻", num);

            case ThemeFontTypes.MinorAscii:
                return BookmarkStart.b("䜩䔫䀭弯䀱申䔵嬷匹唻", num);

            case ThemeFontTypes.MinorBidi:
                return BookmarkStart.b("䜩䔫䀭弯䀱瘳張尷匹", num);

            case ThemeFontTypes.MinorEastAsia:
                return BookmarkStart.b("䜩䔫䀭弯䀱焳圵䬷丹紻䴽⤿⍁", num);

            case ThemeFontTypes.MinorHAnsi:
                return BookmarkStart.b("䜩䔫䀭弯䀱簳眵嘷䤹唻", num);
        }
        return "";
    }

    internal static CharacterCategory smethod_9(string A_0)
    {
        int num = 6;
        string str = A_0;
        if (str != null)
        {
            if ((str == BookmarkStart.b("䤫伭䌯䘱申䔵儷嬹", num)) || (str == BookmarkStart.b("䨫伭䈯圱唳䔵䰷", num)))
            {
                return CharacterCategory.FarEast;
            }
            if (str == BookmarkStart.b("伫崭", num))
            {
                return CharacterCategory.ComplexScript;
            }
        }
        return CharacterCategory.Other;
    }
}

