﻿using ElementFactory.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElementFactory.Data.Configurations
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            string[] schools = "71 СРЕДНО УЧИЛИЩЕ ПЕЙО ЯВОРОВ - КАЗИЧЕНЕ\r\n СРЕДНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - ДУЛОВО\r\n СРЕДНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - СТРЕЛЧА\r\n СРЕДНО УЧИЛИЩЕ ПЕТКО РАЧОВ СЛАВЕЙКОВ - ВИДИН\r\n СРЕДНО УЧИЛИЩЕ ЛЮБЕН КАРАВЕЛОВ - ДИМИТРОВГРАД\r\n СРЕДНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - КРИВОДОЛ\r\n СРЕДНО УЧИЛИЩЕ ХРИСТО БОТЕВ - НИКОПОЛ\r\n СРЕДНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - ЯБЛАНИЦА\r\n СРЕДНО УЧИЛИЩЕ ХРИСТО СМИРНЕНСКИ - ОБРОЧИЩЕ\r\n 37 СРЕДНО УЧИЛИЩЕ РАЙНА КНЯГИНЯ - СОФИЯ\r\n СРЕДНО УЧИЛИЩЕ СВ. КЛИМЕНТ ОХРИДСКИ - РАКИТОВО\r\n СРЕДНО УЧИЛИЩЕ АЛЕКО КОНСТАНТИНОВ - ЛУКОВИТ\r\n СРЕДНО УЧИЛИЩЕ ХРИСТО СМИРНЕНСКИ - ГУЛЯНЦИ\r\n СРЕДНО УЧИЛИЩЕ АНГЕЛ КАРАЛИЙЧЕВ - СТРАЖИЦА\r\n СРЕДНО УЧИЛИЩЕ С ИЗУЧАВАНЕ НА ЧУЖДИ ЕЗИЦИ СВЕТИ КЛИМЕНТ ОХРИДСКИ - БЛАГОЕВГРАД\r\n СЕДМО СРЕДНО УЧИЛИЩЕ ЙОРДАН РАДИЧКОВ - МОНТАНА\r\n 55 СРЕДНО УЧИЛИЩЕ ПЕТКО КАРАВЕЛОВ - СОФИЯ\r\n СРЕДНО УЧИЛИЩЕ ГЕО МИЛЕВ - РАДНЕВО\r\n 27 СРЕДНО УЧИЛИЩЕ АКАД. ГЕОРГИ КАРАСЛАВОВ - СОФИЯ\r\n 17 СРЕДНО УЧИЛИЩЕ ДАМЯН ГРУЕВ - СОФИЯ\r\n СРЕДНО УЧИЛИЩЕ ХРИСТО БОТЕВ - САПАРЕВА БАНЯ\r\n СПОРТНО УЧИЛИЩЕ ГЕОРГИ БЕНКОВСКИ - ПЛЕВЕН\r\n СРЕДНО УЧИЛИЩЕ СВЕТИ КОНСТАНТИН - КИРИЛ ФИЛОСОФ - ПЛОВДИВ\r\n СРЕДНО УЧИЛИЩЕ ПЕТКО РОСЕН - БУРГАС\r\n СРЕДНО УЧИЛИЩЕ ХАДЖИ МИНА ПАШОВ - СЛИВЕН\r\n 14-ТО СРЕДНО УЧИЛИЩЕ ПРОФ. Д-Р АСЕН ЗЛАТАРОВ - СОФИЯ\r\n СРЕДНО УЧИЛИЩЕ НЕОФИТ БОЗВЕЛИ - ВАРНА\r\n СРЕДНО УЧИЛИЩЕ СВ.СВ. КИРИЛ И МЕТОДИЙ - ИГНАТИЕВО\r\n СРЕДНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ИВАЙЛОВГРАД\r\n 144 СРЕДНО УЧИЛИЩЕ НАРОДНИ БУДИТЕЛИ - СОФИЯ\r\n СРЕДНО УЧИЛИЩЕ НАЙДЕН ГЕРОВ - ПЛОВДИВ\r\n СРЕДНО УЧИЛИЩЕ ЕВЛОГИ ГЕОРГИЕВ - ТРЪСТЕНИК\r\n СРЕДНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - ТРОЯН\r\n ЦЕНТЪРЪТ ЗА СПЕЦИАЛНА ОБРАЗОВАТЕЛНА ПОДКРЕПА ПРОФ. ДПН ГЕОРГИ АНГУШЕВ - СОФИЯ\r\n СРЕДНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - ПОРДИМ\r\n СРЕДНО УЧИЛИЩЕ НИКОЛА ЙОНКОВ ВАПЦАРОВ - БЕНКОВСКИ\r\n СРЕДНО УЧИЛИЩЕ ОТЕЦ ПАИСИЙ - КИРКОВО\r\n СРЕДНО УЧИЛИЩЕ СВ. КЛИМЕНТ ОХРИДСКИ - СУХИНДОЛ\r\n 95 СРЕДНО УЧИЛИЩЕ ПРОФ. ИВАН ШИШМАНОВ - СОФИЯ\r\n 78 СРЕДНО УЧИЛИЩЕ ХРИСТО СМИРНЕНСКИ - БАНКЯ\r\n СРЕДНО УЧИЛИЩЕ НИКОЛА ЙОНКОВ ВАПЦАРОВ - МОМЧИЛГРАД\r\n СРЕДНО УЧИЛИЩЕ ХРИСТО СМИРНЕНСКИ - ПЛЕВЕН\r\n СРЕДНО УЧИЛИЩЕ ЧЕРНОРИЗЕЦ ХРАБЪР - ВЕЛИКИ ПРЕСЛАВ\r\n СРЕДНО УЧИЛИЩЕ ОТЕЦ ПАИСИЙ - ВРАЦА\r\n СРЕДНО УЧИЛИЩЕ СВ. ПАИСИЙ ХИЛЕНДАРСКИ - ЗЛАТИЦА\r\n СРЕДНО УЧИЛИЩЕ ПЕЙО КРАЧОЛОВ ЯВОРОВ - ПЛЕВЕН\r\n СРЕДНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - ВЪЛЧИ ДОЛ\r\n ДУХОВНО УЧИЛИЩЕ РУСЕ - РУСЕ\r\n СРЕДНО УЧИЛИЩЕ ХРИСТО СМИРНЕНСКИ - КОЙНАРЕ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ОТЕЦ ПАИСИЙ - СТАМБОЛИЙСКИ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ НИКОЛА ЙОНКОВ ВАПЦАРОВ - ПРИМОРСКО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ АЛЕКСАНДЪР ИВАНОВ ЧАПАЙ - БЕЛОВО\r\n СОУ ХРИСТО БОТЕВ - СУНГУРЛАРЕ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ Д-Р ПЕТЪР БЕРОН - БОЛЯРОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - АНТОНОВО\r\n 15 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ АДАМ МИЦКЕВИЧ - СОФИЯ\r\n 18 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ УИЛЯМ ГЛАДСТОН - СОФИЯ\r\n СОУ ХРИСТО БОТЕВ - ГОРНА МАЛИНА\r\n ЧАСТНО СОУ ДЕЛФИНИТЕ - СТАРОЗАГОРСКИ БАНИ\r\n СОУ НЕОФИТ РИЛСКИ - БАНСКО\r\n СРЕДНО УЧИЛИЩЕ ХАН ИСПЕРИХ - НОВИ ПАЗАР\r\n ВЕЧЕРНО СРЕДНО УЧИЛИЩЕ ЗАХАРИ СТОЯНОВ - СТАРА ЗАГОРА\r\n 94 СРЕДНО УЧИЛИЩЕ ДИМИТЪР СТРАШИМИРОВ - СОФИЯ\r\n СРЕДНО УЧИЛИЩЕ АНТОН ПОПОВ - ПЕТРИЧ\r\n СРЕДНО УЧИЛИЩЕ ВЛАДИМИР ДИМИТРОВ - МАЙСТОРА - КЪРДЖАЛИ\r\n СРЕДНО УЧИЛИЩЕ СВ. КЛИМЕНТ ОХРИДСКИ - КАМЕН\r\n СРЕДНО УЧИЛИЩЕ МАКСИМ РАЙКОВИЧ - ЛЯСКОВЕЦ\r\n 125 СРЕДНО УЧИЛИЩЕ БОЯН ПЕНЕВ С ИЗУЧАВАНЕ НА ЧУЖДИ ЕЗИЦИ - СОФИЯ\r\n СРЕДНО УЧИЛИЩЕ ОТЕЦ ПАИСИЙ - КУКЛЕН\r\n 11 СРЕДНО УЧИЛИЩЕ КОНСТАНТИН КОНСТАНТИНОВ - СЛИВЕН\r\n 137 СРЕДНО УЧИЛИЩЕ АНГЕЛ КЪНЧЕВ - СОФИЯ\r\n СРЕДНО УЧИЛИЩЕ ВАСИЛ ВОДЕНИЧАРСКИ - ХАЙРЕДИН\r\n СРЕДНО УЧИЛИЩЕ ХРИСТО СМИРНЕНСКИ - БЯЛ ИЗВОР\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ ПАИСИЙ ХИЛЕНДАРСКИ - МИКРЕВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ДИМИТЪР МИТЕВ - ЛОВЕЧ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - БЯЛА СЛАТИНА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - ЕЛИН ПЕЛИН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ С ПРОФЕСИОНАЛНИ ПАРАЛЕЛКИ - ВЕТОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ПАИСИЕВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ СВЕТИ КИРИЛ И МЕТОДИЙ - СИНДЕЛ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ. ПАИСИЙ ХИЛЕНДАРСКИ - АБЛАНИЦА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - КАРЛОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - СЛАВЯНОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ДРЕН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ГАБАРЕ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ОТЕЦ ПАИСИЙ - СМОЛЯН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ БАЧО КИРО - ЛЕТНИЦА\r\n ПЕТО СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ПЕТКО РАЧОВ СЛАВЕЙКОВ - ПЕРНИК\r\n ПЕТО СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ГЕОРГИ ИЗМИРЛИЕВ - БЛАГОЕВГРАД\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО СМИРНЕНСКИ - КРУШАРИ\r\n НАРОДНО ЧИТАЛИЩЕ Г.С.РАКОВСКИ-1941Г. - ВАСИЛ ЛЕВСКИ\r\n СОУ СВЕТИ КИРИЛ И МЕТОДИЙ - СТАМБОЛОВО\r\n 68 СОУ АКАДЕМИК НИКОЛА ОБРЕШКОВ - СОФИЯ\r\n СОУ СВЕТИ КНЯЗ БОРИС I - СТАРЦЕВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЙОРДАН ЙОВКОВ - РИБНОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - РУСЕ\r\n СОУ СВ. СВ. КИРИЛ И МЕТОДИЙ - НОВО СЕЛО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЛЮБЕН КАРАВЕЛОВ - НЕСЕБЪР\r\n СОУ КИРИЛ И МЕТОДИЙ - НОВА МАХАЛА\r\n СОУ СВ. СВ. КИРИЛ И МЕТОДИЙ - СЛИВНИЦА\r\n СОУ СВ. СВ. КИРИЛ И МЕТОДИЙ - САТОВЧА\r\n СОУ СВЕТИ СВЕТИ КИРИЛ И МЕТОДИЙ - РУДОЗЕМ\r\n СЕДМО СОУ КУЗМАН ШАПКАРЕВ - БЛАГОЕВГРАД\r\n ПЪРВО СОУ ДИМЧО ДЕБЕЛЯНОВ - ВАРНА\r\n СОУ ГЕО МИЛЕВ - ВАРНА\r\n СОУ ДИМИТЪР БЛАГОЕВ - ПРОВАДИЯ\r\n СОУ ДИМИТЪР МАДЖАРОВ - МАДЖАРОВО\r\n СОУ С ПАРАЛЕЛКИ ЗА ПРИДОБИВАНЕ НА ПРОФЕСИОНАЛНА КВАЛИФИКАЦИЯ МИТО ОРОЗОВ - ВРАЦА\r\n СОУ СВ. КЛИМЕНТ ОХРИДСКИ - ТРОЯН\r\n СОУ ЛЮБЕН КАРАВЕЛОВ - КОПРИВЩИЦА\r\n СОУ ХРИСТО БОТЕВ - БРАТЯ ДАСКАЛОВИ\r\n СОУ СВ. СОФРОНИЙ ВРАЧАНСКИ - ПЛОВДИВ\r\n СОУ ХРИСТО БОТЕВ - ДЕВИН\r\n СОУ КОНСТАНТИН ВЕЛИЧКОВ - ПЛОВДИВ\r\n 117 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ СВЕТИ КИРИЛ И МЕТОДИЙ - БУХОВО\r\n 105 СОУ АТАНАС ДАЛЧЕВ - СОФИЯ\r\n СОУ ХРИСТО БОТЕВ - ВЕТРИНО\r\n СОУ ЙОРДАН ЙОВКОВ - КЪРДЖАЛИ\r\n СОУ СВ. КЛИМЕНТ ОХРИДСКИ - КЪРДЖАЛИ\r\n 1-ВО СОУ СВЕТИ СВЕТИ КИРИЛ И МЕТОДИЙ - СМОЛЯН\r\n ЧСОУ ДРИТА - СОФИЯ\r\n СОУ НИКОЛА ВОЙВОДОВ - ВРАЦА\r\n СОУ ОТЕЦ ПАИСИЙ - МАДАН\r\n СОУ СВ. СВ. КИРИЛ И МЕТОДИЙ - КАРНОБАТ\r\n СОУ СВ. СВ. КИРИЛ И МЕТОДИЙ - ЗАВЕТ\r\n СОУ СВ. ПАИСИЙ ХИЛЕНДАРСКИ - ПЛОВДИВ\r\n СОУ ВАСИЛ ЛЕВСКИ - ГЛАВИНИЦА\r\n СОУ ИВАН ВАЗОВ - СВОГЕ\r\n 3 СОУ МАРИН ДРИНОВ - СОФИЯ\r\n 7 СОУ НАЙДЕН ГЕРОВ - ВАРНА\r\n СОУ ДИМЧО ДЕБЕЛЯНОВ - БУРГАС\r\n СОУ ЙОРДАН ЙОВКОВ - ТЕРВЕЛ\r\n СОУ СВ. ПАИСИЙ ХИЛЕНДАРСКИ - ДУПНИЦА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ИВАН ВАЗОВ - СТАРА ЗАГОРА\r\n СОУ ПАНАЙОТ ВОЛОВ - ШУМЕН\r\n СОУ ХРИСТО ЯСЕНОВ - ЕТРОПОЛЕ\r\n СОУ ПЕЙО КРАЧОЛОВ ЯВОРОВ - СЛИВЕН\r\n СОУ ХРИСТО БОТЕВ - БАЛЧИК\r\n СОУ ЙОРДАН ЙОВКОВ - ТУТРАКАН\r\n СОУ ЦАНКО БАКАЛОВ ЦЕРКОВСКИ - НИКОЛА КОЗЛЕВО\r\n СОУ ХРИСТО БОТЕВ - ЛОЗНИЦА\r\n СОУ ДИМИТЪР ТАЛЕВ - ДОБРИЧ\r\n СОУ НИКОЛА ЙОНКОВ ВАПЦАРОВ - ПЕТРИЧ\r\n СОУ ОТЕЦ ПАИСИЙ - ЛЮЛЯКОВО\r\n СОУ ЮРИЙ АЛЕКСЕЕВИЧ ГАГАРИН - СИЛИСТРА\r\n СОУ ХРИСТО БОТЕВ - ГАЛИЧЕ\r\n СОУ ХРИСТО СМИРНЕНСКИ - ХИСАРЯ\r\n СОУ ХРИСТО СМИРНЕНСКИ - ЧЕРНООЧЕНЕ\r\n СОУ САВО ЦЕНОВ САВОВ - ПИРДОП\r\n СОУ Д-Р ПЕТЪР БЕРОН - ЯКИМОВО\r\n СОУ Д-Р ПЕТЪР БЕРОН - ТОПОЛОВГРАД\r\n ВЕЧЕРНО СОУ ДИМЧО ДЕБЕЛЯНОВ - ДУПНИЦА\r\n 1 СОУ СВЕТИ СЕДМОЧИСЛЕНИЦИ - ТЪРГОВИЩЕ\r\n ЧАСТНО СОУ ОРФЕЙ - СОФИЯ\r\n 7-МО СОУ СВЕТИ СЕДМОЧИСЛЕНИЦИ - СОФИЯ\r\n 32 СОУ С ИЗУЧАВАНЕ НА ЧУЖДИ ЕЗИЦИ СВЕТИ КЛИМЕНТ ОХРИДСКИ - СОФИЯ\r\n ЧСОУ РЬОРИХ - СОФИЯ\r\n СОУ АРГИРА ЖЕЧКОВА - СЛИВЕН\r\n 88 СОУ ДИМИТЪР ПОПНИКОЛОВ - СОФИЯ\r\n СОУ ОТЕЦ ПАИСИЙ - ЛОМ\r\n СОУ ЙОРДАН ЙОВКОВ - СЛИВЕН\r\n 130 СОУ СТЕФАН КАРАДЖА - СОФИЯ\r\n 1 СОУ ПЕНЧО П. СЛАВЕЙКОВ - СОФИЯ\r\n СОУ ОТЕЦ ПАИСИЙ - ГАБРОВО\r\n СОУ НЕОФИТ РИЛСКИ - ТВЪРДИЦА\r\n СОУ ВАСИЛ ЛЕВСКИ - КРУМОВГРАД\r\n СОУ ХРИСТО БОТЕВ - АЙТОС\r\n СОУ ХРИСТО ПРОДАНОВ - КАРЛОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - КОЧЕРИНОВО\r\n СОУ СВ. СВ. КИРИЛ И МЕТОДИЙ - ДВЕ МОГИЛИ\r\n СОУ СВ. КЛИМЕНТ ОХРИДСКИ - ЛОВЕЧ\r\n СОУ НАРОДНИ БУДИТЕЛИ - БРАЦИГОВО\r\n СОУ ЛЮБЕН КАРАВЕЛОВ - ПЛОВДИВ\r\n СОУ ВАСИЛ ЛЕВСКИ - РОМАН\r\n СОУ ХРИСТО СМИРНЕНСКИ - СВЕТА ПЕТКА\r\n СОУ СВ. СВ. КИРИЛ И МЕТОДИЙ - САМУИЛ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ НАЗЪМ ХИКМЕТ - МЕДОВЕЦ\r\n СОУ СВЕТИ КЛИМЕНТ ОХРИДСКИ - ПЕЩЕРА\r\n СОУ СВ. СВ. КИРИЛ И МЕТОДИЙ - СЪРНИЦА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - КОЛАРОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - ВЕЛИНГРАД\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ.СВ.КИРИЛ И МЕТОДИЙ - БЕЛИЦА\r\n 30 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ БРАТЯ МИЛАДИНОВИ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ БАЧО КИРО - ПАВЛИКЕНИ\r\n СОУ С РАЗШИРЕНО ИЗУЧАВАНЕ НА ЧУЖДИ ЕЗИЦИ Д-Р ПЕТЪР БЕРОН - ПЕРНИК\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ИВАН ВАЗОВ - БЛАГОЕВГРАД\r\n СРЕДНO ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - ДЕВНЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ АПРИЛОВ - ДОЛНА МИТРОПОЛИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - БРЕЗНИК\r\n 21 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - СОФИЯ\r\n ПЕТО ВЕЧЕРНО СОУ ПЕНЬО ПЕНЕВ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - ОПАКА\r\n 26 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЙОРДАН ЙОВКОВ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - БОБОВ ДОЛ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - ДОЛНИ ЧИФЛИК\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ НИКОЛА ЙОНКОВ ВАПЦАРОВ - ПЛОВДИВ\r\n 24 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ П.К.ЯВОРОВ - СОФИЯ\r\n 81 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВИКТОР ЮГО - СОФИЯ\r\n 108 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ НИКОЛА БЕЛОВЕЖДОВ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ АНТИМ ? - ЗЛАТОГРАД\r\n 121 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ГЕОРГИ ИЗМИРЛИЕВ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ГЛОДЖЕВО\r\n 73.СОУ С ПРЕПОДАВАНЕ НА ЧУЖДИ ЕЗИЦИ ВЛАДИСЛАВ ГРАМАТИК - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ИВАН ВАЗОВ - МЕЗДРА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ КОНСТАНТИН ПРЕСЛАВСКИ - БУРГАС\r\n 69 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ДИМИТЪР МАРИНОВ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - ЛЕХЧЕВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ГЕОРГИ ИЗМИРЛИЕВ - ГОРНА ОРЯХОВИЦА\r\n 101 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ БАЧО КИРО - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - ЗЛАТАРИЦА\r\n 133 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ \"АЛЕКСАНДЪР СЕРГЕЕВИЧ ПУШКИН\" - СОФИЯ\r\n 74 СОУ ГОЦЕ ДЕЛЧЕВ - СОФИЯ\r\n 134 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ДИМЧО ДЕБЕЛЯНОВ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ.ПАИСИЙ ХИЛЕНДАРСКИ - КРЕСНА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ИХТИМАН\r\n 12 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЦАР ИВАН АСЕН II - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ НИКОЛА ЙОНКОВ ВАПЦАРОВ - ХАДЖИДИМОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - СЪЕДИНЕНИЕ\r\n СОУ ЗА ДЕЦА С НАРУШЕНО ЗРЕНИЕ ЛУИ БРАЙЛ - СОФИЯ\r\n 23 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ФРЕДЕРИК ЖОЛИО-КЮРИ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - УГЪРЧИН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ СЕДМОЧИСЛЕНИЦИ - ПЛОВДИВ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО СМИРНЕНСКИ - СТАРА ЗАГОРА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - СТАРА ЗАГОРА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЕЛИН ПЕЛИН - РУЕН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ТРАЙКО СИМЕОНОВ - ШУМЕН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - СЕВЛИЕВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ДИМИТЪР БЛАГОЕВ - СВИЩОВ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СИМОН БОЛИВАР - ПЛОВДИВ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО ГРУЕВ ДАНОВ - ПЛОВДИВ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ИВАН ВАЗОВ - ПЛЕВЕН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СТОЯН ЗАИМОВ - ПЛЕВЕН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ 'ДИМИТЪР ГАЧЕВ' - ПАЗАРДЖИК\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ Д-Р ПЕТЪР БЕРОН - ПАЗАРДЖИК\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ГЕОРГИ БРЕГОВ - ПАЗАРДЖИК\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ИВАН ВАЗОВ - НОВА ЗАГОРА\r\n СЕДМО СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ПРОФ. Д-Р АСЕН ЗЛАТАРОВ - МОНТАНА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ЦАР КАЛОЯН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВИЧО ГРЪНЧАРОВ - ГОРНА ОРЯХОВИЦА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ДИМИТЪР МАРИНОВ' - ЛОМ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ТОДОР КИРКОВ - ЛОВЕЧ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЛЮБЕН КАРАВЕЛОВ - НЕСЕБЪР\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ БРАТЯ МИЛАДИНОВИ - ПЛОВДИВ\r\n 113 СОУ САВА ФИЛАРЕТОВ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ КЛИМЕНТ ОХРИДСКИ - ПЕРНИК\r\n 44. СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ НЕОФИТ БОЗВЕЛИ - СОФИЯ\r\n 35 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ДОБРИ ВОЙНИКОВ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - АРДИНО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - ШУМЕН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - НЕДЕЛИНО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - ХАСКОВО\r\n 36 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ МАКСИМ ГОРКИ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ОТЕЦ ПАИСИЙ - МЕДКОВЕЦ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ОТЕЦ ПАИСИЙ - САМОКОВ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - НОВА ЗАГОРА\r\n 192 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - БИСТРИЦА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ГРАМАДА\r\n 47 СОУ ХРИСТО Г. ДАНОВ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ГЕОРГИ БЕНКОВСКИ - ТЕТЕВЕН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - КУЛА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ГЕОРГИ БЕНКОВСКИ - ПАЗАРДЖИК\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЛЮБЕН КАРАВЕЛОВ - ВАРНА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВEТИ СВЕТИ КИРИЛ И МЕТОДИЙ - ЗЕМЕН\r\n 40 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЛУИ ПАСТЬОР - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ НИКОЛА ЙОНКОВ ВАПЦАРОВ - БОРИНО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ САВА ДОБРОПЛОДНИ - ШУМЕН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО ОЗДРАВИТЕЛНО УЧИЛИЩЕ НИКОЛА ЙОНКОВ ВАПЦАРОВ - БЕЛИЦА\r\n ПЕТО СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - МОНТАНА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ДОРА ГАБЕ - ДОБРИЧ\r\n 39 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ПЕТЪР ДИНЕКОВ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - БАНИТЕ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ КЛИМЕНТ ОХРИДСКИ - ДЪЛГОПОЛ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЦВЕТАН РАДОСЛАВОВ - СВИЩОВ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ Д-Р ПЕТЪР БЕРОН - ЧЕРВЕН БРЯГ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ПЕТКО РАЧОВ СЛАВЕЙКОВ - ДОБРИЧ\r\n ВТОРО СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ НИКОЛА ЙОНКОВ ВАПЦАРОВ - МОНТАНА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - КАМЕНО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЕКЗАРХ АНТИМ ? - КАЗАНЛЪК\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ДРАГОМАН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - МАЛКО ТЪРНОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЙОАН ЕКЗАРХ БЪЛГАРСКИ - ШУМЕН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО СМИРНЕНСКИ - БРЕЗОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ПАНАЙОТ ВОЛОВ - КАСПИЧАН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ С ПРИРОДОМАТЕМАТИЧЕСКА НАСОЧЕНОСТ ОТЕЦ ПАИСИЙ - КЪРДЖАЛИ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ДОЛНИ ДЪБНИК\r\n ШЕСТО СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ СВЕТИ КИРИЛ И МЕТОДИЙ - ПЕРНИК\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - ВЕЛИНГРАД\r\n 93-ТО СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ АЛЕКСАНДЪР ТЕОДОРОВ - БАЛАН - СОФИЯ\r\n 145 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СИМЕОН РАДЕВ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - КОЗЛОДУЙ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ НЕОФИТ РИЛСКИ - КНЕЖА\r\n 127 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ИВАН НИКОЛАЕВИЧ ДЕНКОГЛУ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СТЕФАН КАРАДЖА - КАВАРНА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ДРУМЕВ - ВАРНА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ НИКОЛА ЙОНКОВ ВАПЦАРОВ - СИЛИСТРА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ МАКСИМ ГОРКИ - СТАРА ЗАГОРА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ НИКОЛАЙ КАТРАНОВ - СВИЩОВ\r\n 118 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ АКАДЕМИК ЛЮДМИЛ СТОЯНОВ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЦАР СИМЕОН ВЕЛИКИ - ПЛОВДИВ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - ДИМИТРОВГРАД\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ Д-Р ПЕТЪР БЕРОН - КОСТИНБРОД\r\n ВТОРО СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ПРОФЕСОР НИКОЛА МАРИНОВ - ТЪРГОВИЩЕ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ НЕОФИТ РИЛСКИ - ХАРМАНЛИ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ. ПАИСИЙ ХИЛЕНДАРСКИ - ВЪРБИЦА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВЕЛА БЛАГОЕВА - ВЕЛИКО ТЪРНОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЕМИЛИЯН СТАНЕВ - ВЕЛИКО ТЪРНОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ГЕОРГИ СТОЙКОВ РАКОВСКИ - ВЕЛИКО ТЪРНОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ СВЕТИ КИРИЛ И МЕТОДИЙ - ПЛОВДИВ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ.СВ. КИРИЛ И МЕТОДИЙ - ЯКОРУДА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЕЛИН ПЕЛИН - ВАРНА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО ДУХОВНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - ПЛОВДИВ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ПАНАЙОТ ПИПКОВ - ЛОВЕЧ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - НОВИ ПАЗАР\r\n 28 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ АЛЕКО КОНСТАНТИНОВ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЧЕРНОРИЗЕЦ ХРАБЪР - ПЛОВДИВ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ КОНСТАНТИН ПЕТКАНОВ - БУРГАС\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЙОРДАН ЙОВКОВ - БУРГАС\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ С ХУМАНИТАРНО- ЕСТЕТИЧЕСКИ ПРОФИЛ СВ.СВ. КИРИЛ И МЕТОДИЙ - БУРГАС\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ,,ДОБРИ ЧИНТУЛОВ - БУРГАС\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - ГЪЛЪБОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ПЕТКО РАЧЕВ СЛАВЕЙКОВ - ТРЯВНА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВЛАДИМИР КОМАРОВ - ВЕЛИКО ТЪРНОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ИВАН ВАЗОВ - СОПОТ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ.ПАИСИЙ ХИЛЕНДАРСКИ - ХАСКОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ТУТРАКАН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ПРОФ. Д-Р АСЕН ЗЛАТАРОВ - ПЪРВОМАЙ\r\n 170 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - НОВИ ИСКЪР\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ КЛИМЕНТ ОХРИДСКИ - АКСАКОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ КЛИМЕНТ ОХРИДСКИ - СИМЕОНОВГРАД\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ИВАН Н. МОМЧИЛОВ - ЕЛЕНА\r\n СОУ ДИМЧО ДЕБЕЛЯНОВ - БЕЛЕНЕ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО ДУХОВНО УЧИЛИЩЕ НЮВВАБ - ШУМЕН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ КЛИМЕНТ ОХРИДСКИ - ПЛОВДИВ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ АНАСТАСИЯ ДИМИТРОВА - ПЛЕВЕН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ КНЯЗ БОРИС I - АСЕНОВГРАД\r\n 131 СОУ КЛИМЕНТ АРКАДИЕВИЧ ТИМИРЯЗЕВ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ Д-Р ПЕТЪР БЕРОН - СВИЛЕНГРАД\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ПЕТКО РАЧОВ СЛАВЕЙКОВ - КРИЧИМ\r\n СОУ ХРИСТО БОТЕВ - ЧЕПИНЦИ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - СМЯДОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ НИКОЛА ЙОНКОВ ВАПЦАРОВ - ВЕНЕЦ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ КЛИМЕНТ ОХРИДСКИ - СТАМБОЛОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - КАРАМАНЦИ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ПРОФ. Д-Р АСЕН ЗЛАТАРОВ - МИНЕРАЛНИ БАНИ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЖЕЛЯЗКО ТЕРПЕШЕВ - ЛЮБИМЕЦ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ПАВЕЛ БАНЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО СМИРНЕНСКИ , ГР.ГУРКОВО - ГУРКОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЖЕЛЕЗНИК - СТАРА ЗАГОРА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ СВЕТИ КИРИЛ И МЕТОДИЙ - ВЪРБИНА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ДИМИТЪР БЛАГОЕВ - ДОСПАТ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ГЕОРГИ АЛЕКСИЕВ КАРАВЕЛОВ - ШИВАЧЕВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЙОРДАН ЙОВКОВ - ОКОРШ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ПРОФ. Д-Р АСЕН ЗЛАТАРОВ - ГОДЕЧ\r\n 22 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ГЕОРГИ СТОЙКОВ РАКОВСКИ - СОФИЯ\r\n 8 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - СОФИЯ\r\n 29 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ КУЗМАН ШАПКАРЕВ - СОФИЯ\r\n 149 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ИВАН ХАДЖИЙСКИ - СОФИЯ\r\n 128 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ АЛБЕРТ АЙНЩАЙН - СОФИЯ\r\n 10 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ТЕОДOР TРАЯНОВ - СОФИЯ\r\n 97 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ БРАТЯ МИЛАДИНОВИ - СОФИЯ\r\n 96 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ С ИЗУЧАВАНЕ НА ЧУЖДИ ЕЗИЦИ ЛЕВ НИКОЛАЕВИЧ ТОЛСТОЙ - СОФИЯ\r\n 90 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ГЕНЕРАЛ ХОСЕ ДЕ САН МАРТИН - СОФИЯ\r\n 79 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ИНДИРА ГАНДИ - СОФИЯ\r\n 85 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ОТЕЦ ПАИСИЙ - СОФИЯ\r\n 135 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЯН АМОС КОМЕНСКИ - СОФИЯ\r\n 123 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СТЕФАН СТАМБОЛОВ - СОФИЯ\r\n 119 СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ АКАДЕМИК МИХАИЛ АРНАУДОВ - СОФИЯ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ПАИСИЙ ХИЛЕНДАРСКИ - ПРИПЕК\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ КЛИМЕНТ ОХРИДСКИ - ДОБРИЧ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ КЪНЧОВ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ КОЗМА ТРИЧКОВ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ СВЕТИ КИРИЛ И МЕТОДИЙ - ВИДИН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЦАР СИМЕОН ВЕЛИКИ - ВИДИН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ВИДИН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ НИКОЛА ЙОНКОВ ВАПЦАРОВ - ДРЕНОВЕЦ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - БРЕГОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - БЕЛОГРАДЧИК\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЛЮБЕН КАРАВЕЛОВ - ВИДИН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - БЕЛОСЛАВ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ПЕЙО КРАЧОЛОВ ЯВОРОВ - ВАРНА\r\n VIII СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ С ПРЕПОДАВАНЕ НА ЧУЖДИ ЕЗИЦИ АЛ. С. ПУШКИН - ВАРНА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ЦАНКО ЦЕРКОВСКИ - ПОЛСКИ ТРЪМБЕШ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ СВЕТИ КИРИЛ И МЕТОДИЙ - СРЕДЕЦ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ЧЕРНО МОРЕ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ НИКОЛА ЙОНКОВ ВАПЦАРОВ - АЙТОС\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ КЛИМЕНТ ОХРИДСКИ - БОРОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - КУБРАТ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ЛЪКИ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ СВЕТИ КИРИЛ И МЕТОДИЙ - АСЕНОВГРАД\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО СМИРНЕНСКИ - ИСКЪР\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО СМИРНЕНСКИ - СЕПТЕМВРИ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ МЕТОДИЙ ДРАГИНОВ - ДРАГИНОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - СЕПТЕМВРИ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ КИРИЛ И МЕТОДИЙ - НОВА МАХАЛА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - БРУСАРЦИ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ВАСИЛ ЛЕВСКИ - БОЙЧИНОВЦИ\r\n ОСМО СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ОТЕЦ ПАИСИЙ - МОНТАНА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВЕТИ СВЕТИ КИРИЛ И МЕТОДИЙ - АЛЕКСАНДРОВО\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО СМИРНЕНСКИ - КОЧАН\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ ХРИСТО БОТЕВ - ВЪЛКОСЕЛ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ.ПАИСИЙ ХИЛЕНДАРСКИ - ПЪРВОМАЙ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ БРАТЯ ПЕТЪР И ИВАН КАНАЗИРЕВИ - РАЗЛОГ\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - БРЕЗНИЦА\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ. СВ. КИРИЛ И МЕТОДИЙ - СИМИТЛИ\r\n ОСМО СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ АРСЕНИ КОСТЕНЦЕВ - БЛАГОЕВГРАД\r\n СРЕДНО ОБЩООБРАЗОВАТЕЛНО УЧИЛИЩЕ СВ.СВ.КИРИЛ И МЕТОДИЙ - ГЪРМЕН"
            .Split("\r\n ");

            var schoolsList = new List<School>();
            var id = 1;

            foreach (string school in schools)
            {
                var entity = new School()
                {
                    Name = school,
                    Id = id
                };

                id++;

                schoolsList.Add(entity);
            }

            builder.HasData(schoolsList);
        }
    }
}
