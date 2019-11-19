﻿using UnityEngine;
using System;
using System.Collections;
using System.IO;

public class SX_File : MonoBehaviour {

    void Start()
    {
        if(!Directory.Exists("SX")){
            Directory.CreateDirectory("SX");
        }      
        
        if(!File.Exists("SX/basa.ini")){
            File.Create("SX/basa.ini");
        }
        Save();
    }
    void Save(){

            using (System.IO.StreamWriter file = 
            new System.IO.StreamWriter(@"SX/basa.ini"))
            foreach (string line in baza_new.words)
            {
                // If the line doesn't contain the word 'Second', write the line to the file.
                if (!line.Contains("Second"))
                {
                    file.WriteLine(SortWords(line));
                    //file.WriteLine(baza.words[l,0] +","+ baza.words[l,1] + "," +baza.words[l,2]);
                }

            }


            //for (int l=0; l> baza.words.Length; l++)
             //   file.WriteLine(baza.words[l,0] +","+ baza.words[l,1] + "," +baza.words[l,2]);

            
    }

    string SortWords(string w){
        string[] words = w.Split(","[0]);
        string text3 ="";
        string text4 ="";
        string text5 ="";
        string text6 ="";
        string text7 ="";
        string text8 ="";
		for(int j=4; j<words.Length; j++)
		{
            if(!delWronWord(words[j]))
            {      
                if(words[j].Length==3) text3+=words[j]+",";
                if(words[j].Length==4) text4+=words[j]+",";
                if(words[j].Length==5) text5+=words[j]+",";	
                if(words[j].Length==6) text6+=words[j]+",";	
                if(words[j].Length==7) text7+=words[j]+",";		
                if(words[j].Length==8) text8+=words[j]+",";	
            }		
		}
        return "{"+words[0]+",,"+(text3.Split(","[0]).Length+text4.Split(","[0]).Length+text5.Split(","[0]).Length-3).ToString()+",,"+text3+text4+text5+text6+text7+text8+"}";
    }

    bool delWronWord(string w)
    {





        string t = "кмин,пнище,денщик,темь,мосье,менада,наемка,буер,буза,буча,зебу,тейп,протей,понтер,вирш,бод,ибис,наос,пися,стачка,аттик,трасер,отрог,изотон,отгон,зарок,кобза,разок,заборка,клотик,рогоз,ямс,пенс,авто,наос,намин,анион,аноним,амнион,потир,мирр,приор,чех,апач,харч,тыща,фот,мосток,помоствеха,,парча,авто,наос,фикс,ненка,данник,дензнак,порты,ламер,ареал,денник,тиккер,реликт,внос,чатни,носач,ночва,скрап,стаз,теза,есть,куна,мора,муар,мура,крон,торн,корч,отек,кочет,очерк,тонер,кречет,кетон,кретон,очерет,дан,дак,лари,ранка,аркан,арника,наклад,радиан,иранка,драник,дранка,ирландка,ларго,логик,накол,горлан,горлик,оркан,крона,нолик,каолин,линкор,наилок,горилка,органик,срубка,карибу,бусинка,бурсак,рубаи,телок,затесь,бакан,танка,каприс,стола,парка,комара,нарком,камора,ранка,нырок,тоник,возчик,водичка,заводик,аркан,талия,легат,литера,реалия,летяга,гирло,голик,руна,виконт,шинок,кетон,бистр,иракец,ядрица,ариец,цедра,ярица,мирка,клокот,смоль,метол,отмель,колет,лепет,отплеск,катран,кварта,квинта,краина,ракита,травка,антиква,вариант,натирка,тиранка,травина,ратник,тваринка,травинка,мякина,поимка,японка,поминка,чинар,чадра,анчар,насад,саван,копна,окот,ерик,ряда,комп,янки,кома,вага,сван,опт,соте,опал,плав,радиан,степ,лесок,откус,квант,копна,копка,синдик,индикт,дикаин,ситник,актинид,дискант,арника,варнак,ватник,иранка,урез,абрек,уход,ходун,водник,духовик,мгла,шуга,шала,лага,кент,кисет,кисея,синяк,пук,кеб,бек,волан,чур,фук,куфа,ужак,фука,ляжка,кумжа,мялка,жито,ауто,иол,кут,севр,саше,верша,глум,шлаг,неон,ярд,зам,маз,вьюк,азан,диез,деза,тег,кака,ямина,имя,наци,амия,уния,циан,иная,сиг,гит,гиат,грат,титр,хана,бали,хина,хлад,ладан,халда,бахила,гон,анид,арго,врио,диво,дина,дари,дива,гидра,динго,инвар,надир,онагр,година,одрина,нал,алан,налим,ласина,ореол,орало,манат,мотка,октан,крапп,пипа,парс,паск,арык,скип,кипа,сель,кеч,зет,дао,зав,лит,аят,нал,лата,алет,теин,абрис,пан,горал,огрех,мэр,мга,мант,мирт,гам,этан,эмир,грат,грант,мигрант,бот,мот,мант,нотка,матка,пикап,пипка,ость,чорт,мга,окра,кош,керш,гон,усик,бит,ера,рея,маки,оскал,силок,виола,кости,колит,сотка,сивко,совка,автол,валок,вилок,лиска,литва,литка,сивка,силка,скало,совик,солка,стило,стоик,талик,вист,ласт,килт,окат,скит,вика,влас,ивка,илот,кила,киот,клот,осил,свал,сикл,став,аил,вак,вис,кил,ков,кси,сак,сот,тал,икс,лов,тис,ост,лик,тол,акр,орк,копр,крап,каре,клер,перл,веко,реал,ваер,верк,елка,капо,клев,копа,креп,опак,пола,раек,рало,рева,роек,валек,валер,варок,капер,карел,ковер,копал,копер,перка,перло,плева,повал,ропак,капор,лепра,креол,колер,копра,ант,арк,кан,ара,сан,аир,наст,атас,сари,скан,тина,анис,стан,раса,арак,арат,каин,карт,крин,натр,рака,рант,ринк,тари,тирс,трак,астра,акант,антик,карст,накра,нарта,раина,ратин,риска,ситар,скарн,триас,сатир,бис,бра,бук,бур,бус,кун,кур,кус,ура,нуб,бан,барк,барс,баск,бикс,брас,бука,буки,букс,бура,наиб,раус,саиб,сбир,сука,сура,уник,анус,бакун,бирка,брика,букан,букса,бурак,буран,бурка,бурса,кариб,русак,русин,сабур,скарб,сурик,сурна,уника,урина,усина,аул,аут,бут,луб,тау,тук,тул,уда,аид,баул,блуд,иуда,кади,кули,луда,лука,туба,улит,битка,булат,дубка,дутик,кабил,кабул,латук,улита,талиб,удила,батик,дек,дер,док,дол,кап,лар,лед,лек,ода,одр,пак,пал,пек,под,рад,дека,дока,дора,драп,дрек,дрок,кода,одер,паек,пард,докер,дорка,корда,ион,кон,лаж,лаз,лан,лжа,низ,нок,оаз,она,ажио,жако,жило,зало,зоил,инок,кило,лино,жинка,зажин,золка,инока,кожан,лазок,лонжа,низка,низок,лет,тес,фал,фат,фес,ласа,лафа,леса,саек,флат,лета,слет,стек,стела,аскет,феска,ласка,клест,лафет,летка,стека,талес,таска,теска,фасет,мар,сам,сие,мира,рамс,амин,иена,мерс,маис,мара,мари,мена,миса,саам,сама,сема,сима,мание,манси,маран,масаи,минер,саман,серна,сиена,сирен,мерин,манер,ага,агу,ген,гну,нет,нут,тун,унт,агар,агат,гаер,гарт,гнет,гран,гурт,гута,нега,негр,нуга,раут,руга,руте,терн,трен,туга,туер,туна,тунг,агнат,антре,гетра,грена,гуран,ранет,рента,таган,теург,турне,унтер,ёра,лёт,орт,пат,тёк,топ,копт,отёл,плат,прок,раёк,роёк,тёпа,тора,торк,трал,трок,троп,апорт,копёр,кроат,лётка,отпал,пёрка,потёк,тапёр,лен,чал,коча,ленч,чаек,лечо,чело,челн,чека,жалко,кочан,ночка,желна,женка,колча,лежка,ленок,чекан,челка,кок,вар,мор,како,кока,орок,мавр,морок,кокор,мокко,ромок,азу,раз,кура,риза,азур,криз,куть,узик,закут,круть,тузик,уазик,разик,они,мол,ном,пес,пим,пси,сип,иное,осел,пеон,плес,слип,слом,плис,плие,спил,слом,пион,мопс,сени,сонм,плен,сплин,пилон,мелос,милое,олеин,плесо,помин,селин,силон,мала,нома,лама,чалма,накал,камча,коала,манок,калан,ланка,лачка,макао,малка,манко,молка,чакан,чалкадон,анод,вона,драч,нард,рвач,чван,норд,дойна,дойра,навой,овчар,радон,ирга,рига,тиун,гитан,игрун,тигра,униат,ять,тля,боа,ляп,альт,топь,паль,паля,пяла,пяло,толь,блато,паяло,полба,тябло,виг,гик,гак,иго,овин,вгон,очин,чина,гичка,ковач,нивка,новик,чинка,вира,барит,старь,триба,вол,цук,увал,орс,сор,укор,коми,миро,умок,умор,ирмос,скорм,мирок,сомик,дон,сап,дог,донг,пеан,саго,сгад,сгон,сопа,посад,падог,саднобич,абак,набат,читка,лиф,линт,фиал,фила,фита,лафит,тат,тот,тата,тори,трог,трот,тога,тиара,торит,сард,кадка,арека,аскер,карда,серка,чес,чет,кетч,счет,тета,чета,сеча,катет,астат,секач,татка,тетка,ческа,див,иод,едок,веди,вено,девон,дичок,видок,сев,вех,див,дот,иод,веди,дите,свих,свое,сеид,вест,твид,деист,досев,истод,тодес,хедив,саз,тут,тута,усол,лаг,зга,клен,леза,газик,елина,линек,ерь,лье,ларь,риал,дерть,литер,литье,трель,талер,клир,корд,лори,клико,колик,кроки,окрол,орлик,колок,оклик,баз,зоб,раба,зала,араб,абаз,арба,трут,уток,утор,тор,тутор,трико,кета,опор,пате,тепа,патер,порто,тапер,ропот,садно,добор,оброк,саква,саржа,залет,затек,излет,важа,чара,котел,ледок,клеть,ушан,жниво,нотис,остов,ярка,крица,ракия,рацея,цадик,царек,аэрон,орлан,мирта,митра,рев,пава,арап,веда,дерн,рапа,дрена,панер,редан,варан,нерпа,тан,ушат,бон,бор,гук,бург,горн,орун,борок,горно,бонго";
     
        string[] words = t.Split(","[0]);
        foreach (string line in words)
            if(line==w)
                return true;

        return false;
    }
}
