using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace winapp
{
    public partial class TextForm : Form
    {
        public object openFileDialog1;

        public TextForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            this.Hide();
        }
        private void OpenFileText(string str)
        {
            using (FileStream filestream = new FileStream(str, FileMode.Open))
            {
                StreamReader streamReader = new StreamReader(filestream, Encoding.Default);
                richTextBox1.Text = streamReader.ReadToEnd();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileText("Fleischsorten.txt");
            //richTextBox1.Text = " Fleischsorten" +
            //    "\n " +                
            //    "\n Verschiedene Fleischerzeugnisse und Gerichte werden aus unterschiedlichen Fleischsorten zubereitet.Zum Fleisch gehören genießbare Teile von Huftieren und Einhufern(Schwein, Rind, Ziege, Schaf, Hasentiere, Geflügel, Wild)." +
            //    "\n " +
            //    "\n Die Köche unterscheiden zwischen weißem und rotem Fleisch. Zu rotem Fleisch gehören Kalbfleisch, Rindfleisch, Lammfleisch, Pferdefleisch, Schweinefleisch, Schaffleisch, Kaninchenfleisch und Wild(Hasenfleisch, Rehfleisch, Wildschweinfleisch, Hirschfleisch, etc.).Zu weißem Fleisch zählt man Haus - und Wildgeflügel: Hühnerfleisch, Gänsefleisch, Putenfleisch, Entenfleisch; Fasanenfleisch, Taubenfleisch, Wachtelfleisch, Rebhühner Fleisch, Wildentenfleisch etc.In einigen Regionen können spezifische und für Europäer ungewöhnliche Tiere geschlachtet und gegessen werden(Bären, Katzen, Kamele, Hunde, Schildkröten, Affen etc.)." +
            //    "\n " +
            //    "\n Verschiedene Meeresfrüchte, Fische, Schnecken und Frösche sind kaltblutig und werden zu den oben genannten Fleischsorten überhaupt nicht gezählt." +
            //    "\n " +
            //    "\n Fleisch ist neben den Nahrungsmitteln pflanzlicher Herkunft ein sehr wichtiges Mittel für die Ernährung der Menschen. In verschiedenen Ländern ist der Fleischkonsum nicht gleich und beträgt im Durchschnitt von 40 kg(in den unterentwickelten Ländern) bis 100 kg(in den hochentwickelten Ländern) pro Kopf jährlich.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " Im Kaufhaus" +
                "\n " +
                "\n In der Hauptstraße unserer Stadt befindet sich ein großes Warenhaus mit breiten herrlichen Schaufenstern. Dort gibt es so schöne Sachen!Man sieht da Kleider, Wäsche, Stoffe, Schuhe, Mäntel für jeden möglichen Geschmack." +
                "\n " +
                "\n Manchmal besuche ich das Warenhaus mit den Eltern oder mit meiner besten Freundin." +
                "\n " +
                "\n Heute bin ich hier mit meinen Eltern, weil wir etwas zum Neujahr kaufen müssen." +
                "\n " +
                "\n Zuerst gehen wir in die Abteilung 'Damenkonfektion'.Meine Mutter will sich ein Kleid kaufen. Sie wählt ein blaues modernes Kleid aus Wolle. Die Mutter probiert das Kleid an, es passt ihr. Die Äugen meiner Mutter sind blau, und das Kleid steht ihr sehr gut. Die blaue Farbe macht sie jung und anziehend. Wir bewundern Mutti.Der Vater zahlt an der Kasse, und wir bekommen das Kleid an der Warenausgabe.Das Kleid ist nicht teuer." +
                "\n " +
                "\n Meine Eltern machen die Mode mit, darum muss man auch für den Vater etwas Modernes kaufen.Unser nächstes Ziel ist die Abteilung 'Hemden'.Dem Vater gefallen helle Oberhemden mit modernen Kragen.Er kauft eins.Das gestreifte seidene Hemd steht ihm gut.Der Vater freut sich über den Einkauf." +
                "\n " +
                "\n Ich will auch modern sein.Ich habe schon lange von einem schicken Mantel geträumt, aber die Mutter sagt, dass mein alter Mantel noch nicht aus der Mode ist.Man muss den Eltern gehorchen!Wir kommen in die Abteilung, wo man Pullover verkauft.Da gibt es viele gestrickte Sachen. Etwas davon gefällt mir. Ich probiere einen weißen Pullover an, aber er ist mir zu lang.Die Verkäuferin hilft mir. Sie zeigt uns noch einen Pulli in Weiß.Er ist wunderbar und ganz meine Größe.Wir zahlen an der Kasse und die Verkäuferin gibt uns den Pullover. Ich bin zufrieden.Er ist modern." +
                "\n " +
                
                "\n Wortschatz:" +
                "\n das Schaufenster -витрина" +
                "\n gestreift - полосатый" +
                "\n für jeden möglichen Geschmack - на любой вкус" +
                "\n seiden - шелковый" +
                "\n modern sein -быть модным" +
                "\n anziehend - привлекательный" +
                "\n aus der Mode sein -выйти из моды" +
                "\n die Warenausgabe -отдел выдачи товаров" +
                "\n gehorchen - слушаться, повиноваться" +
                "\n die Mode mitmachen -следовать моде" +
                "\n anprobieren - примерять что - то" +
                "\n j - m passen - быть впору, подходить";
       //     pictureBox1.BackgroundImage =  ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " Im Supermarkt" +
                "\n " +
                "\n – P.Was haben wir zu kaufen ?" +
                "\n – H.Von Milchprodukten: eine Flasche Milch, ein halbes Kilo Käse und zwei Packungen Butter. Sowie brauchen wir ein Kilo Schweinefleisch für den Braten, ein bißchen Schinken, frische Tomaten und Gurken sowie irgendwelches Obst." +
                "\n – H.Sagen Sie bitte, wo hier die Milchprodukte verkauft werden?" +
                "\n – V.Jetzt gehen Sie rechts, nach der Fleischabteilung biegen Sie links ab, dorthin finden Sie die Milchabteilung." +
                "\n – P.Entschuldigung, stehen die Käse in der Milchabteilung zur Auswahl?" +
                "\n – V.Doch.Es gibt hier eine einzelne Käseabteilung." +
                "\n – H.Können Sie mir klären, warum dieser Käse Gauda grundsätzlich billiger ist als ein anderer Gauda?" +
                "\n – V.Erstens, das sind die Käse von verschiedenen Marken, zweitens, für diesen Käse gelten jetzt preisgünstige Angebote." +
                "\n – P.Ist dieser Schinken frisch?" +
                "\n – V.Ja.Er ist heute morgens angeliefert." +
                "\n – P.Wiegen Sie bitte vierhundert Gramm Käse sowie ein halbes Kilo Schinken und schneiden Sie ihn in Scheiben." +
                "\n – P.Und wo wird hier Wein verkauft?" +
                "\n – V.In der Spirituosenabteilung, neben der Tabakwarenabteilung." +
                "\n – P.Wollen wir eine Torte nehmen." +
                "\n – H.Beiläufig ist unser Kaffee zu Ende gegangen.Deswegen müss man sowie eine Kaffeedose kaufen." +
                "\n – H.Was sind wir schuldig? Und geben Sie bitte eine Tüte.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " Im Kaufhaus" +
                "\n " +
                "\n – Die Abteilung Damenbekleidung ist im zweiten Stock. Gehen wir hin?" +
                "\n – Ja, aber die anderen Abteilungen möchte ich auch besuchen. Aber das wird später, wenn wir das Kleid kaufen." +
                "\n – Da ist die Abteilung Damenbekleidung." +
                "\n – Guten Tag. Was kann ich für Sie tun?" +
                "\n – Guten Tag. Helfen Sie bitte meiner Freundin. Sie möchte ein Abendkleid kaufen." +
                "\n – Bitte schön. Hier haben wir Kleider. Welche Größe haben Sie?" +
                "\n – Größe 46	" +
                "\n – Und welcher Farbe brauchen Sie?" +
                "\n – Das kann ich nicht genau sagen. Das Abendkleid muss dunkel sein, glaube ich." +
                "\n – Wir haben hier schwarze, blaue und rote Abendkleider." +
                "\n – Zeigen Sie mir, bitte, ein rotes Kleid." +
                "\n – Probieren Sie mal dieses hier. Es ist sehr schön und aus gutem Stoff." +
                "\n – Oh, das ist so elegant. Ist es aber nicht zu teuer?" +
                "\n – Ach so, es kostet 100 Mark." +
                "\n – Also gut, und wo kann ich das Kleid probieren?" +
                "\n – Da ist ein Ankleideraum. Dort können Sie es anziehen." +
                "\n – Erna, ist der Rock nicht zu kurz?" +
                "\n – Nein, gar nicht. Ich finde das Kleid steht dir prima." +
                "\n – Ich glaube, dass ich zum neuen Kleid auch neue Schuhe brauche." +
                "\n – Die Abteilung Damenschuhe liegt im Erdgeschoß." +
                "\n – Dann gehen wir hin." +
                "\n – Da ist die Abteilung Damenschuhe. Ich kenne die Verkäuferin gut. Guten Tag, Frau Anna." +
                "\n – Guten Tag. Wie kann ich Ihnen helfen?" +
                "\n – Frau Anna, tun Sie mir den Gefallen, zeigen Sie bitte diese Damenschuhe." +
                "\n – Bitte sehr. Wir haben gerade Damenschuhe mit Absätzen aus Frankreich bekommen. Weiße, schwarze, rote, blaue." +
                "\n – Die schwarze Schuhe passt nicht zum roten Kleid, nicht wahr?" +
                "\n – Doch, das sieht ganz hübsch aus." +
                "\n – Na, dann ist gut. Wo soll ich zahlen?" +
                "\n – Zahlen Sie, bitte, dort an der Kasse." +
                "\n – Okay, jetzt können wir die anderen Abteilungen besuchen.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " Im Supermarkt" +
                " Heute ist Samstag.Gewöhnlich geht mein Vater an diesem Tag einkaufen. " +
                "Der Supermarkt liegt nicht weit von unserem Haus. Ich will auch mitgehen, das macht mir Spaß." +
                "\n " +
                "\n Im Supermarkt gibt es verschiedene Abteilungen, z. B.für Fleisch und Wurst, für Milchprodukte, Gemüse, Obst und Getränke.Da ist Selbstbedienung und wir nehmen einen Korb. " +
                "\n " +
                "\n Zuerst kaufen wir zwei Kilo Tomaten. Wir essen Tomatensalat gern. Ich lege ein Kilo Äpfel in unseren Korb. Die Mutter hat uns ge¬beten noch Kohl zu kaufen.Heute macht sie Kohlrouladen. Der Vater sagt, dass der Kohl billig ist." +
                "\n " +
                "\n Wir nehmen 10 Eier.Oft essen wir morgens Spiegelei.Würstchen brauchen wir auch. Manchmal ist es sehr gut Würstchen zum Frühstück zu essen. Wurst brauchen wir nicht. Wir haben genug zu Hause." +
                "\n " +
                "\n Ich habe gezuckerte Kondensmilch gern.Der Vater weiß das und nimmt für mich eine Büchse. " +
                "\n " +
                "\n Da erinnern wir uns an das Fleisch.Natürlich brauchen wir Schweinefleisch. Am Sonntag haben wir Besuch und die Mutter will Schweinebraten zubereiten.Fisch brauchen wir nicht, aber eine Ente müssen wir kaufen.Bald habe ich Geburtstag. Zum Geburtstag wird meine Mutter eine Ente mit Äpfeln braten. " +
                "In der Abteilung für Milchprodukte kaufen wir ein Stück Butter, holländischen Käse, eine Packung Quark und Joghurt.Für unsere Katze kaufen wir eine Packing Milch. " +
                "Mein Vater trinkt gewöhnlich Mineralwasser vor dem Essen, darum kauft er eine Flasche. Für Mutter kaufen wir Apfelsaft." +
                "Endlich ist unser Korb voll.Wir haben alles gekauft, was wir brauchen. Die Waren sind frisch. Der Vater zahlt an der Kasse und wir gehen nach Hause."+
                "\n " +
                "\n Wortschatz" +
                "die Selbstbedienung - самообслуживание" +
                "die Büchse -банка" +
                "der Schweinebraten -жаркое из свинины" +
                "der Korb -корзина" +
                "die Kohlrouladen -голубцы" +
                "das Spiegelei -яичница - глазунья" +
                "gezuckerte Kondensmilch -сгущенное молоко";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " In der Abteilung der Kinderwaren" +
                "\n " +
                "\n – Sieh mal, wie reich das Angebot ist.Kleider, Röcke, Blusen, Hemden, Mäntel" +
                "\n – alles kann man für ein Kind kaufen." +
                "\n – Und dort rechts verkauft man Mützen, Schuhe, Strumpfhosen, Strickwaren." +
                "\n – Du brauchst doch einen Pullover. Dann gehen wir in jene Abteilung." +
                "\n – Was darf es sein, meine Dame?" +
                "\n – Ich hätte gern einen Pullover für einen Jungen." +
                "\n – Wie alt ist der Junge?" +
                "\n – 7 Jahre." +
                "\n – Wie wäre es mit diesem blauen Pullover?" +
                "\n – Der ist schön, aber zeigen Sie mir noch jenen bunten." +
                "\n – Bitte sehr.Und was sagen Sie zu diesem roten Pullover?" +
                "\n – Kannst du mir bei der Wahl helfen?" +
                "\n – Ja, man sagt nicht umsonst: Wer die Wahl hat, hat die Qual." +
                "\n – Mir gefällt am besten der bunte Pullover. On er aber meiner Schwester und dem Jungen gefallen wird?" +
                "\n – Über den Geschmack lässt sich nicht streiten." +
                "\n – Also, ich nehme den bunten, denn er ist praktischer als der blaue und der rote.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " In der Damenkonfektion" +
                "\n " +
                "\n – Was wünschen die Damen ?" +
                "\n – Ich möchte eine Bluse." +
                "\n – In Ihrer Größe habe ich diese rote, diese blaue und diese grüne." +
                "\n – Weißt du, solche Blusen sind jetzt große Mode." +
                "\n – Diese grüne Bluse kannst du zu deinem braunen Rock tragen." +
                "\n – Die Blusen sind wirklich hübsch. Aber ich möchte eine Bluse für meine Schwester. Und sie wünscht sich eine in Weiß.Diese Farbe steht ihr nämlich sehr gut." +
                "\n – Diese Farbe haben wir auch. Bitte sehr." +
                "\n – Darf ich sie anprobieren ?" +
                "\n – Bitte, hier ist die Ankleidekabine." +
                "\n – Na, wie findet ihr diese Bluse ?" +
                "\n – Fantastisch.Sie passt auch gut und sitzt ausgezeichnet." +
                "\n – Ist das aber schick!" +
                "\n – Nun, nehmen Sie die Bluse?" +
                "\n – Ja, was kostet sie ?" +
                "\n – 80 Mark.Sie zahlen bitte an der Kasse.Hier ist Ihr Kassenzettel. Die Warenausgabe ist gleich links." +
                "\n – Recht schönen Dank." +
                "\n – Haben Sie noch einen Wunsch?" +
                "\n – Nein, danke." +
                "\n – Ein guter Kauf, muss ich sagen. Schön und preiswert." +
                "\n – Ich meine, die Schwester wird mit dem Geschenk zufrieden sein." +
                "\n – Und ob!So was hat sie sich schon immer gewüns";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " In der Drogerie" +
                "\n " +
                "\n Anna: Schönen guten Tag!" +
                "\n Verkäuferin: Guten Tag!Kann ich Ihnen helfen?" +
                "\n Anna: Ja, bitte.Ich muss heute viele verschiedene Sachen kaufen.In einigen Fällen brauche ich Ihre Beratung." +
                "\n Verkäuferin: OK.Womit fangen wir an?" +
                "\n Anna: Zuerst zähle ich Körperpflegemittel auf, die ich für das Badezimmer brauche. In diesem Zusammenhang habe ich keine Fragen." +
                "\n Verkäuferin: Ich höre Ihnen sehr aufmerksam zu." +
                "\n Anna: Also, ich brauche dieses Duschgel für Frauen, dieses Duschgel für Männer, dieses Intimgel, zwei Stück Seife mit Olivenöl, Haarschampoo mit Kamille, diese Haarspülung und Flüssigseife mit Lavendel." +
                "\n Verkäuferin: Hier ist alles, was Sie aufgezählt haben." +
                "\n Anna: Danke.Ich brauche noch diverse Reinigungsmittel.Und ich möchte, dass Sie mir effektive Mittel empfehlen." +
                "\n Verkäuferin: Für welche Zwecke brauchen sie die Reinigungsmittel?" +
                "\n Anna: Für Kachel, für Toilettenbecken, für Badewanne und für Spiegel." +
                "\n Verkäuferin: Ich würde Ihnen diese Reinigungsmittel empfehlen. Sie sind sehr populär und ich kaufe sie auch.Ich kann Ihnen zusichern, dass sie wirklich sehr effektiv sind." +
                "\n Anna: Vielen Dank!" +
                "\n Verkäuferin: Noch etwas?" +
                "\n Anna: Ja, bitte.Ich habe über die Haarfarbe vergessen. Zeigen Sie mir bitte, welche Varianten von dunkelblond Sie haben." +
                "\n Verkäuferin: Bitte schön." +
                "\n Anna: Ich nehme diese Haarfarbe. Das wäre alles." +
                "\n Verkäuferin: Gut.Ich packe alles zusammen und dann bekommen Sie Ihre Rechnung. Sie werden die Rechnung bestimmt mit einer Kreditkarte bezahlen?" +
                "\n Anna: Natürlich, ich kaufe so viel auf einmal. Hier ist meine Karte." +
                "\n Verkäuferin: OK.Alles ist in Ordnung.Hier sind Ihre Waren." +
                "\n Anna: Danke!Auf Wiedersehen!" +
                "\n Verkäuferin: Auf Wiedersehen!";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " In der Geschenkabteilung" +
                "\n " +
                "\n In unserer Stadt ist ein großes Warenhaus. Hier wendet man neue Handelsmethoden an, damit die Käufer weniger Zeit für Einkäufe verlieren.Im Warenhaus gibt es verschiedene Abteilungen. Einige Abteilunge haben Selbstbedienung." +
                "\n Besonders gut ist die Geschenkabteilung.Hier gibt es immer eine große Auswahl von Waren, die sich als Geschenke eignen, und von Geschenkpackungen, die aus zueinanderpassenden Einzelstücken bestehen.Vor den Feiertagen wird großer Betrieb sein, und die Auswahl wird zusammenschrumpfen." +
                "\n Gestern besuchte ich die Geschenkabteilung.Ich suchte Geschenke zum Geburtstag für meine Schwiegermutter und für meine ältere Schwester Olga." +
                "\n Meine Schwiegermutter ist eine nicht mehr junge Frau, aber sie hält auf Mode. Ich habe für sie eine Einkaufstasche aus Kunstleder mit Reißverschluß gekauft.Diese Tasche ist praktisch, modern, kann zu jeder Farbe der Kleidung passen." +
                "\n Für meine Schwester habe ich Creme und Parfüm gekauft.Olga mag einen herben Geruch." +
                "\n Die Verkäuferin packt meine Geschenke extra ein.";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " In der Herrenkonfektion" +
                "\n " +
                "\n Verkäuferin: Einen schönen guten Tag, kann ich vielleicht Ihnen helfen?" +
                "\n Der Kunde: Guten Tag, ja, bitte, Ihre Hilfe würde ich gerne gebrauchen." +
                "\n Verkäuferin: Ist mir ein Vergnügen. Ich sehe, Sie suchen einen festlichen Anzug." +
                "\n Der Kunde: Ja, stimmt, mein Bruder heiratet nächste Woche, ich bin dazu eingeladen. Mein alter Anzug ist mir leider zu eng geworden, deshalb brauche ich einen neuen.." +
                "\n Verkäuferin: Ist ja kein großes Problem.Wir suchen was ganz besonderes aus." +
                "\n Der Kunde: Nein - nein, danke, gerade das möchte ich nicht.Ich bevorzuge eher unauffällige Anzüge." +
                "\n Verkäuferin: Ach so, alles klar.In diesem Fall brauchen wir etwas klassisches, richtig?" +
                "\n Der Kunde: Ja, Sie haben vollkommen Recht. Klassik ist unsterblich und immer aktuell. Es würde mir passen." +
                "\n Verkäuferin: Ok.Ich schätze, Sie haben die Größe L im Oberteil, aber Unterteil ist etwas kleiner, ich denke Größe M." +
                "\n Der Kunde: Ja - ja, meine Figur ist ein bisschen unregelmäßig." +
                "\n Verkäuferin: Keine Sorge, ich finde schon was.Welche Anzugsfarbe hätten Sie lieber: schwarz oder grau?" +
                "\n Der Kunde: Schwarz, ich mag schwarz." +
                "\n Verkäuferin: Gut, dann probieren Sie bitte diesen Anzug an.Die Umkleidekabine finden Sie hinter den Tresen." +
                "\n Der Kunde: Gut.Aber entschuldigen Sie bitte, die Hosenkanten hier unten sind nicht bearbeitet. Wie ist es möglich?" +
                "\n Verkäuferin: Ach das. Das ist aber kein Fehler, alles gehört dazu.Die Hosenkanten lassen wir absichtlich unbearbeitet, damit man die Hosenlänge korrigieren kann.Wenn der Anzug Ihnen passt, bearbeiten wir sofort hier auf der Stelle die Hosenkanten ihrer Größe nach. Alles klar?" +
                "\n Der Kunde: Ja, ich habe alles kapiert. Prima!" +
                "\n Verkäuferin: Na, wie geht es Ihnen? Wie sieht es aus?" +
                "\n Der Kunde: Mir gefällt es.Es passt ganz gut, aber die Ärmer sind etwas länger als es nötig ist." +
                "\n Verkäuferin: Die bringen wir schon in Ordnung und machen sie gerne für Sie kürzer. Ja, dieser Anzug steht Ihnen wirklich sehr gut." +
                "\n Der Kunde: Echt? Dann nehme ich ihn.Wie lange dauert es, die Hosenkanten und die Ärmel kürzer machen?" +
                "\n Verkäuferin: In einer Stunde soll es schon fertig sein. Aber wenn Sie keine Zeit zum Warten haben, können Sie uns Ihre Adresse hinterlassen.Wir schicken den fertigen Anzug für Sie nach Hause." +
                "\n Der Kunde: Das wäre ja super. Was kostet er?" +
                "\n Verkäuferin: 800 Euro bitte." +
                "\n Der Kunde: Ok, kann ich mit Kreditkarte bezahlen?" +
                "\n Verkäuferin: Ja, natürlich." +
                "\n Der Kunde: Danke sehr. Einen schönen Tag noch." +
                "\n Verkäuferin: Ebenso danke. Auf Wiedersehen.";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " In der Kurzwarenabteilung" +
                "\n " +
                "\n – Wo kann man hier ein seidenes Tuch kaufen ?" +
                "\n – Tücher verkauft man in der Kurzwarenabteilung dort rechts." +
                "\n – Die Damen wünschen?" +
                "\n – Würden Sie mir bitte ein schönes seidenes Tuch zeigen." +
                "\n – Bitte sehr.Tücher haben wir in allen Farben. Soll es ein einfarbiges oder ein buntes sein?" +
                "\n – Ein buntes bitte." +
                "\n – Dann empfehle ich Ihnen dieses gestreifte Tuch. Solche Tücher sind jetzt große Mode." +
                "\n – Was meinst du, wird das gestreifte Tuch meiner Mutti gefallen?" +
                "\n – Ich glaube, das wäre das Richtige für sie, schlicht und zugleich schön." +
                "\n – Und zu ihrem braunen Mantel muss es auch passen." +
                "\n – Gut, ich nehme es.Was habe ich zu zahlen ?" +
                "\n – 24 Mark bitte.Sonst noch ein Wunsch?" +
                "\n – Nein, danke.";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " Овощи и фрукты – залог здоровья" +
                "\n " +
                "\n Ich lebe gesund.Ein gesunder Geist wohnt in einem gesunden Körper – so lautet das alte bekannte lateinische Sprichwort.Die gesunde Lebensweise ist aber für mich nicht nur das Sporttreiben, sondern auch die gesunde Ernährung.Um nützliche Vitamine zu bekommen und seltener krank zu sein, muß man viel Obst und Gemüse zu essen." +
                "\n Morgens(vor der Arbeit) trinke ich keinen Tee oder keinen Kaffee, sondern einen frisch gepressten Saft.Den Saft aus dem Tetrapak trinke ich seltener, weil er weniger Vitamine enthält. Morgens bevorzuge ich einen Karottensaft oder Apfelsaft.Abends nach dem Training trinke ich eine Saftmischung. Ich schäle erst eine Orange, Banane und einen Apfel, dann schneide ich sie in Stücke und presse den Saft." +
                "\n Da es in meinem Land im Winter kalt ist, wird viel Obst und Gemüse eingeführt.Aus diesem Grund sind sie ziemlich teuer.Manches Obst wie Johannisbeere und Himbeere ist in den kalten Jahresalt gar nicht verkäuflich. Um es im Winter essen und zum Beispiel ein Kompott machen zu können, wird es im Sommer in den Gefrierschrank gelegt und bis zum Winter gelagert." +
                "\n Aus dem frischen Gemüse bereite ich oft die Salate zu. In meiner Familie genießt einen Salat aus den Karotten, dem Weißkohl, Kraut, der Rübe und Zwiebel große Popularität.Er ist nicht nur lecker, sondern auch nützlich." +
                "\n Ich esse auch das Gemüse als Beilage.Ich schmore es doch nicht, sondern gare kurz, weil das Gemüse dabei mehr Vitamine erhalten bleibt." +
                "\n " +
                "\n Лексика(Wortschatz):" +
                "\n Вести здоровый образ жизни – gesund leben" +
                "\n В здоровом теле – здоровый дух – Ein gesunder Geist wohnt in einem gesunden Körper" +
                "\n Фреш, свежевыжатый сок – der frisch gepresste Saft" +
                "\n Здоровое питание – die gesunde Ernährung" +
                "\n Морковный, яблочный сок – Der Karottensaft, der Apfelsaft" +
                "\n Пить сок – Den Saft trinken" +
                "\n Чистить кожуру – schälen" +
                "\n Выдавливать сок из… – Den Saft aus…pressen" +
                "\n Резать на кусочки – In Stücke schneiden" +
                "\n Готовить салат – Einen Salat zubereiten" +
                "\n Класть в морозильник – In den Gefrierschrank legen" +
                "\n Жарить(овощи) – schmoren" +
                "\n Жарить(мясо, рыбу) – braten" +
                "\n Овощи на пару – kurzgegartes Gemüse";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog of = new OpenFileDialog();
                of.ShowDialog();
                label1.Text = of.FileName;
                StreamReader sr = new StreamReader(label1.Text);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();*/

            /*Stream myStream = null;
            // openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt; *.doc; *.docx)|*.txt; *.doc; *.docx";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            label1.Text = openFileDialog1.FileName;
                            textBox1.Text = File.ReadAllText(label1.Text);// Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

                // textBox1.Text = new char(openFileDialog1.FileName);
            }*/
        }
    }
}
