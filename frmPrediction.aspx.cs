using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;

namespace patternPrediction.VDoctor
{
    public partial class frmPrediction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                _symptoms.Clear();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                lbtnDiseaseName.Text = lblTreatment.Text = string.Empty;

                //code to remove the stop words [preprocessing of data]
                string[] stopwords = { "a", "about", "above", "above", "across", "after", "afterwards", "again", "against", "all", "almost", "alone", "along", "already", "also", "although", "always", "am", "among", "amongst", "amoungst", "amount", "an", "and", "another", "any", "anyhow", "anyone", "anything", "anyway", "anywhere", "are", "around", "as", "at", "back", "be", "became", "because", "become", "becomes", "becoming", "been", "before", "beforehand", "behind", "being", "below", "beside", "besides", "between", "beyond", "bill", "both", "bottom", "but", "by", "call", "can", "cannot", "cant", "co", "con", "could", "couldnt", "cry", "de", "describe", "detail", "do", "done", "down", "due", "during", "each", "eg", "eight", "either", "eleven", "else", "elsewhere", "empty", "enough", "etc", "even", "ever", "every", "everyone", "everything", "everywhere", "except", "few", "fifteen", "fify", "fill", "find", "fire", "first", "five", "for", "former", "formerly", "forty", "found", "four", "from", "front", "full", "further", "get", "give", "go", "had", "has", "hasnt", "have", "he", "hence", "her", "here", "hereafter", "hereby", "herein", "hereupon", "hers", "herself", "him", "himself", "his", "how", "however", "hundred", "ie", "if", "in", "inc", "indeed", "interest", "into", "is", "it", "its", "itself", "keep", "last", "latter", "latterly", "least", "less", "ltd", "made", "many", "may", "me", "meanwhile", "might", "mill", "mine", "more", "moreover", "most", "mostly", "move", "much", "must", "my", "myself", "name", "namely", "neither", "never", "nevertheless", "next", "nine", "no", "nobody", "none", "noone", "nor", "not", "nothing", "now", "nowhere", "of", "off", "often", "on", "once", "one", "only", "onto", "or", "other", "others", "otherwise", "our", "ours", "ourselves", "out", "over", "own", "part", "per", "perhaps", "please", "put", "rather", "re", "same", "see", "seem", "seemed", "seeming", "seems", "serious", "several", "she", "should", "show", "side", "since", "sincere", "six", "sixty", "so", "some", "somehow", "someone", "something", "sometime", "sometimes", "somewhere", "still", "such", "system", "take", "ten", "than", "that", "the", "their", "them", "themselves", "then", "thence", "there", "thereafter", "thereby", "therefore", "therein", "thereupon", "these", "they", "thickv", "thin", "third", "this", "those", "though", "three", "through", "throughout", "thru", "thus", "to", "together", "too", "top", "toward", "towards", "twelve", "twenty", "two", "un", "under", "until", "up", "upon", "us", "very", "via", "was", "we", "well", "were", "what", "whatever", "when", "whence", "whenever", "where", "whereafter", "whereas", "whereby", "wherein", "whereupon", "wherever", "whether", "which", "while", "whither", "who", "whoever", "whole", "whom", "whose", "why", "will", "with", "within", "without", "would", "yet", "you", "your", "yours", "yourself", "yourselves", "the" };

                string[] sentance = null;
                sentance = txtSymptoms.Text.Split('.');
                List<string> specialWords = new List<string>();

                for (int z = 0; z < sentance.Length; z++)
                {
                    specialWords.Clear();

                    string[] opinion = sentance[z].Split(',');

                    for (int y = 0; y < opinion.Length; y++)
                    {
                        opinion[y] = opinion[y].Replace(",", String.Empty);
                        opinion[y] = opinion[y].Replace("?", String.Empty);
                        opinion[y] = opinion[y].Replace(":", String.Empty);
                        opinion[y] = opinion[y].Replace("(", String.Empty);
                        opinion[y] = opinion[y].Replace(")", String.Empty);
                    }

                    for (int j = 0; j < opinion.Length; j++)
                    {
                        if (!stopwords.Contains(opinion[j], StringComparer.InvariantCultureIgnoreCase))
                        {
                            specialWords.Add(opinion[j]);
                        }
                    }
                }

                //loading the keywords into string array
                string[] Keywords = specialWords.ToArray();

                string[] Symptoms = { "frothy-salivation","reduced-appetite","resistance-oralExamination","mouth-ulcer","vesicles","gas-bloat","ptyyalism","nasal-discharge","asphyxia","bruxism",
                                        "bloat","increased-salivation","difficulty-swallowing","shallow-breathing","coughing","anorexia","recurrent-bloat","decreased-milk","weight-loss",
                                         "reduced-appetite","diarrhea","Increased-heart-rate","Increased-breathing","decreased-rumen-motility","fever","poorly-digested","pain",
                                        "diarrhea","dysentery","abdominal-pain","mucosal-damage","mucosal-petechiation","GI-hemorrhage","anorexia","decreased-milk","sunken-eyes","twisting-stomach",
                                        "rectal-pain","diarrhea","bleeding","discharge","sever-anemia","diarrhoea","reduced-appetite","Anemia","colic-diarrhoea","respiratory-noise",
                                        "nasal-discharge","dysphagia","reduced-appetite","Increased-respiratory-rate","cough","nasal-discharge","dyspnea","anorexia","constipation",
                                        "grey/white-skin","ash-skin","red-patches","red-patch","papules","nodules","hair-loss","thickened-skin","lesions","itching",
                                         "skin-thicken","folds","Pruritus","itching","hair-loss","alopatia",
                                    
                                    
                                    "vulvar-swelling","labia-swelling","vulvar-discharge","vaginal-mucosa","straining-urination","grayish-discharge","pale-yellow-discharge","weakness","fowl-smell",
                                    "arch-back","deacreased-urination","uterus-pus","discharge-vulva","swelling-abdomen","enlarged-uterus","red-brown-fluid","uterine-discharge","foetid-odour",
                                    "laminitis","constipation","infection-uterus", "focal-hemorrhages","subcutaneous-tissues","bleeding-spots","blood-from-skin","tearing,spasms-lids",
                                    "squinting","spilling-tears","epiphora","avoidance-sunlight","photophobia","redness","discharge-eye","corneal-ulcers","weeping","closure-pain",
                                    "cornea-cloudy","cornea-white","eye-pain","bleeding-nostril","bleeding-eyeball","bloody","ulcerated","friable","foul-smelling","mass-eye","snoring","nodules",
                                    "febrile","anorectic","ear-pain","head-shaking","facial-nerve-paralysis","red-gum","salivation","difficult-open-mouth","staggering","trembling","breathing-difficulty",
                                    "convulsions","bloat","swollen-thigh","sound-thigh","salivation","nasal-discharge","swelling-throat","drooling","slobbering","smacking-lips",
                                    "shivering","sore-feet","drooling","blisters","swollen-udder","flabes","blood-millshardness","reddening","abortion","fowl-smell","high-fever","ocular-discharge",
                                    "eye-discharge","seizures","coffee-colour-urine","anorexia","diarrhea","jaundice","anorexia","brown-urine","aggression","difficulty-breathing","rapid-pulse",
                                     "tachypnoea","anaemia","rapid-breathing","hypoglucemia","seizure","anemia","anorexia","itching","impaired-coordination","lameness",
                                     "hyper-salivation","choking","aggressive-behavior","attacking-animals"};

                lbtnDiseaseName.ForeColor = System.Drawing.Color.Red;
                lbtnDiseaseName.Font.Bold = true;
                lbtnDiseaseName.Font.Size = 16;

                if (Keywords.Contains("frothy-salivation") || Keywords.Contains("reduced-appetite") || Keywords.Contains("resistance-oralExamination") || Keywords.Contains("mouth-ulcer") || Keywords.Contains("vesicles"))
                {
                    lbtnDiseaseName.Text = "stomatitis";
                }
                else if (Keywords.Contains("gas-bloat") || Keywords.Contains("ptyyalism") || Keywords.Contains("nasal-discharge") || Keywords.Contains("asphyxia") || Keywords.Contains("bruxism"))
                {
                    lbtnDiseaseName.Text = "esophagitis";
                }
                else if (Keywords.Contains("bloat") || Keywords.Contains("increased-salivation") || Keywords.Contains("difficulty-swallowing") || Keywords.Contains("shallow-breathing") || Keywords.Contains("coughing"))
                {
                    lbtnDiseaseName.Text = "choke";
                }
                else if (Keywords.Contains("anorexia") || Keywords.Contains("recurrent-bloat") || Keywords.Contains("decreased-milk") || Keywords.Contains("weight-loss"))
                {
                    lbtnDiseaseName.Text = "ruminal impaction";
                }
                else if (Keywords.Contains("reduced-appetite") || Keywords.Contains("diarrhea") || Keywords.Contains("Increased-heart-rate") || Keywords.Contains("Increased-breathing"))
                {
                    lbtnDiseaseName.Text = "ruminal acidosis";
                }
                else if (Keywords.Contains("decreased-rumen-motility") || Keywords.Contains("fever") || Keywords.Contains("poorly-digested") || Keywords.Contains("pain"))
                {
                    lbtnDiseaseName.Text = "traumatic reticulopericarditis";
                }
                else if (Keywords.Contains("diarrhea") || Keywords.Contains("dysentery") || Keywords.Contains("abdominal-pain") || Keywords.Contains("mucosal-damage")
                    || Keywords.Contains("mucosal-petechiation") || Keywords.Contains("GI-hemorrhage"))
                {
                    lbtnDiseaseName.Text = "enteritis";
                }
                else if (Keywords.Contains("anorexia") || Keywords.Contains("decreased-milk") || Keywords.Contains("sunken-eyes") || Keywords.Contains("twisting-stomach"))
                {
                    lbtnDiseaseName.Text = "volvulus";
                }
                else if (Keywords.Contains("rectal-pain") || Keywords.Contains("diarrhea") || Keywords.Contains("bleeding") || Keywords.Contains("discharge"))
                {
                    lbtnDiseaseName.Text = "proctitis";
                }
                else if (Keywords.Contains("sever-anemia") || Keywords.Contains("diarrhoea") || Keywords.Contains("reduced-appetite"))
                {
                    lbtnDiseaseName.Text = "tape worm infection";
                }
                else if (Keywords.Contains("Anemia") || Keywords.Contains("colic-diarrhoea"))
                {
                    lbtnDiseaseName.Text = "round worm infection";
                }

                else if (Keywords.Contains("respiratory-noise") || Keywords.Contains("nasal-discharge") || Keywords.Contains("coughing") || Keywords.Contains("dysphagia"))
                {
                    lbtnDiseaseName.Text = "pharyngitis";
                }
                else if (Keywords.Contains("reduced-appetite") || Keywords.Contains("Increased-respiratory-rate") || Keywords.Contains("cough") || Keywords.Contains("nasal-discharge"))
                {
                    lbtnDiseaseName.Text = "pneumonia";
                }
                else if (Keywords.Contains("cough") || Keywords.Contains("dyspnea") || Keywords.Contains("anorexia") || Keywords.Contains("constipation"))
                {
                    lbtnDiseaseName.Text = "bronchitis";
                }
                else if (Keywords.Contains("grey/white-skin") || Keywords.Contains("ash-skin") || Keywords.Contains("red-patches") || Keywords.Contains("red-patch"))
                {
                    lbtnDiseaseName.Text = "ringworm";
                }
                else if (Keywords.Contains("papules") || Keywords.Contains("nodules") || Keywords.Contains("hair-loss") || Keywords.Contains("thickened-skin") || Keywords.Contains("itching"))
                {
                    lbtnDiseaseName.Text = "demodicosis";
                }
                else if (Keywords.Contains("skin-thicken") || Keywords.Contains("folds") || Keywords.Contains("Pruritus"))
                {
                    lbtnDiseaseName.Text = "scabies";
                }
                else if (Keywords.Contains("vulvar-swelling") || Keywords.Contains("labia-swelling") || Keywords.Contains("vulvar-discharge") || Keywords.Contains("vaginal-mucosa"))
                {
                    lbtnDiseaseName.Text = "vaginitis";
                }
                else if (Keywords.Contains("grayish-discharge") || Keywords.Contains("pale-yellow-discharge") || Keywords.Contains("weakness"))
                {
                    lbtnDiseaseName.Text = "cervicitis";
                }
                else if (Keywords.Contains("fowl-smell") || Keywords.Contains("arch-back") || Keywords.Contains("deacreased-urination"))
                {
                    lbtnDiseaseName.Text = "pyometra";
                }

                else if (Keywords.Contains("uterus-pus") || Keywords.Contains("discharge-vulva") || Keywords.Contains("swelling-abdomen"))
                {
                    lbtnDiseaseName.Text = "endometritis";
                }
                else if (Keywords.Contains("enlarged-uterus") || Keywords.Contains("red-brown-fluid") || Keywords.Contains("uterine-discharge") || Keywords.Contains("foetid-odour"))
                {
                    lbtnDiseaseName.Text = "metritis";
                }
                else if (Keywords.Contains("laminitis") || Keywords.Contains("constipation") || Keywords.Contains("infection-uterus"))
                {
                    lbtnDiseaseName.Text = "septic-metritis";
                }
                else if (Keywords.Contains("focal-hemorrhages") || Keywords.Contains("subcutaneous-tissues") || Keywords.Contains("bleeding-spots") || Keywords.Contains("blood-from-skin"))
                {
                    lbtnDiseaseName.Text = "filariasis";
                }
                else if (Keywords.Contains("tearing") || Keywords.Contains("spasms-lids") || Keywords.Contains("squinting") || Keywords.Contains("spilling-tears") || Keywords.Contains("epiphora") || Keywords.Contains("avoidance-sunlight") || Keywords.Contains("photophobia"))
                {
                    lbtnDiseaseName.Text = "corneal-opacity";
                }
                else if (Keywords.Contains("weeping") || Keywords.Contains("closure-pain") || Keywords.Contains("cornea-cloudy") || Keywords.Contains("cornea-white"))
                {
                    lbtnDiseaseName.Text = "conjunctivitis";
                }
                else if (Keywords.Contains("bleeding-nostril") || Keywords.Contains("bleeding-eyeball"))
                {
                    lbtnDiseaseName.Text = "frontal-epithelium";
                }
                else if (Keywords.Contains("bloody") || Keywords.Contains("ulcerated") || Keywords.Contains("friable") || Keywords.Contains("foul-smelling"))
                {
                    lbtnDiseaseName.Text = "squamous-cell-carcinoma";
                }
                else if (Keywords.Contains("dyspnoea") || Keywords.Contains("snoring") || Keywords.Contains("nodules"))
                {
                    lbtnDiseaseName.Text = "nasal-granuloma";
                }
                else if (Keywords.Contains("febrile") || Keywords.Contains("anorectic") || Keywords.Contains("ear-pain") || Keywords.Contains("facial-nerve-paralysis"))
                {
                    lbtnDiseaseName.Text = "otitis";
                }
                else if (Keywords.Contains("red-gum") || Keywords.Contains("salivation") || Keywords.Contains("difficult-open-mouth"))
                {
                    lbtnDiseaseName.Text = "gingivitis";
                }
                else if (Keywords.Contains("staggering") || Keywords.Contains("trembling") || Keywords.Contains("breathing-difficulty") || Keywords.Contains("convulsions")) 
                {
                    lbtnDiseaseName.Text = "anthrax";
                }
                else if (Keywords.Contains("swollen-thigh") || Keywords.Contains("sound-thigh"))
                {
                    lbtnDiseaseName.Text = "black-quarter";
                }
                else if (Keywords.Contains("salivation") || Keywords.Contains("nasal-discharge") || Keywords.Contains("swelling-throat") || Keywords.Contains("drooling"))
                {
                    lbtnDiseaseName.Text = "hemorrhagic-septicemia";
                }
                else if (Keywords.Contains("slobbering") || Keywords.Contains("smacking-lips") || Keywords.Contains("shivering") || Keywords.Contains("sore-feet"))
                {
                    lbtnDiseaseName.Text = "foot-mouth-disease";
                }               
                else if (Keywords.Contains("swollen-udder") || Keywords.Contains("flabes") || Keywords.Contains("blood-millshardness") || Keywords.Contains("reddening"))
                {
                    lbtnDiseaseName.Text = "mastitis";
                }
                else if (Keywords.Contains("abortion") || Keywords.Contains("fowl-smell"))
                {
                    lbtnDiseaseName.Text = "brucellosis";
                }


                else if (Keywords.Contains("high-fever") || Keywords.Contains("diarrhea") || Keywords.Contains("ocular-discharge") || Keywords.Contains("eye-discharge"))
                {
                    lbtnDiseaseName.Text = "bovine-malignant-catarrhal-fever";
                }
                else if (Keywords.Contains("coffee-colour-urine") || Keywords.Contains("anorexia") || Keywords.Contains("diarrhea"))
                {
                    lbtnDiseaseName.Text = "babesiosis";
                }
                else if (Keywords.Contains("jaundice") || Keywords.Contains("anorexia") || Keywords.Contains("brown-urine") || Keywords.Contains("aggression"))
                {
                    lbtnDiseaseName.Text = "anaplasmosis";
                }
                else if (Keywords.Contains("tachypnoea") || Keywords.Contains("anaemia"))
                {
                    lbtnDiseaseName.Text = "theileriosis";
                }

                else if (Keywords.Contains("hypoglucemia") || Keywords.Contains("seizure") || Keywords.Contains("anemia"))
                {
                    lbtnDiseaseName.Text = "trypanosomiasis";
                }
                else if (Keywords.Contains("anorexia") || Keywords.Contains("itching") || Keywords.Contains("impaired-coordination") || Keywords.Contains("lameness"))
                {
                    lbtnDiseaseName.Text = "rabies";
                }
                else
                {
                    lbtnDiseaseName.Text = "Invalid Data";
                }
            }
            catch
            {

            }

        }

        protected void lbtnDiseaseName_Click(object sender, EventArgs e)
        {
            try
            {
                lblTreatment.ForeColor = System.Drawing.Color.DarkGreen;
                lblTreatment.Font.Bold = true;
                lblTreatment.Font.Size = 16;

                if (lbtnDiseaseName.Text.Equals("stomatitis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "oxytetracycline/Melonex/Boroglycerine";
                }
                else if (lbtnDiseaseName.Text.Equals("esophagitis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "streptopenicillin/Melonex";
                }
                else if (lbtnDiseaseName.Text.Equals("choke"))
                {
                    lblTreatment.Text = "Treatment Details: " + "streptopenicillin/Melonex/CPM";
                }
                else if (lbtnDiseaseName.Text.Equals("ruminal impaction"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Bovilax/Ecotas-bolus/Ketonex-bolus/MgSO4";
                }
                else if (lbtnDiseaseName.Text.Equals("ruminal acidosis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "sodium-bicarbonate/Bufzone-powder/Ecotas-bolus/Ketonex-bolus";
                }
                else if (lbtnDiseaseName.Text.Equals("traumatic reticulopericarditis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Better-Surgery/streptopenicillin/melonex";
                }
                else if (lbtnDiseaseName.Text.Equals("enteritis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Intamox/Enrofloxacin/RL-fluids/DNS-fluids";
                }
                else if (lbtnDiseaseName.Text.Equals("volvulus"))
                {
                    lblTreatment.Text = "Treatment Details: " + "surgery/Enrofloxacin/Melonex/CPM";
                }
                else if (lbtnDiseaseName.Text.Equals("proctitis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Enrofloxacin/Melonex/DNS/5%Dextrose";
                }
                else if (lbtnDiseaseName.Text.Equals("tape worm infection"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Albendazole/Tribivet/Imferon/mineral-mixture";
                }
                else if (lbtnDiseaseName.Text.Equals("round worm infection"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Ivermectin-injection/Zanide-L/Tribivet/Belamyl-injection/Imferon";
                }


                else if (lbtnDiseaseName.Text.Equals("pharyngitis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Enrofloxacin/CPM/Melonex";
                }
                else if (lbtnDiseaseName.Text.Equals("pneumonia"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Intamox/CPM/Melonex";
                }
                else if (lbtnDiseaseName.Text.Equals("bronchitis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Enrofloxacin/CPM/Melonex";
                }
                else if (lbtnDiseaseName.Text.Equals("ringworm"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Ivermectin/Almizol cream/CPM";
                }
                else if (lbtnDiseaseName.Text.Equals("demodicosis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Amitraz application/Ivermection/CPM/Kiskin-cream";
                }
                else if (lbtnDiseaseName.Text.Equals("scabies"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Benzyl-benzoate-cream/CPM/Ivermection";
                }
                else if (lbtnDiseaseName.Text.Equals("vaginitis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "lorexane-ointment/soframycin-ointment/streptopenicillin/melonex";
                }
                else if (lbtnDiseaseName.Text.Equals("cervicitis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "streptopenicillin/ceftriaxone/melonex";
                }
                else if (lbtnDiseaseName.Text.Equals("pyometra"))
                {
                    lblTreatment.Text = "Treatment Details: " + "streptopenicillin/oxytetracycline/Melonex";
                }
                else if (lbtnDiseaseName.Text.Equals("endometritis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "streptopenicillin/oxytetracycline/lixen-I.U-intrauterine/Melonex";
                }

                else if (lbtnDiseaseName.Text.Equals("metritis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "streptopenicillin/lixen-I.U.intrauterine/oxytetracycline/Melonex";
                }
                else if (lbtnDiseaseName.Text.Equals("septic metritis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "streptopenicillin/oxytetracycline/lixen-I.U.intrauterine/Melonex";
                }
                else if (lbtnDiseaseName.Text.Equals("filariasis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Ivermection";
                }
                else if (lbtnDiseaseName.Text.Equals("corneal opacity"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Dexorens eye drops/vitade injection";
                }
                else if (lbtnDiseaseName.Text.Equals("conjunctivitis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Dexorens-eye-drops/gentamicin";
                }
                else if (lbtnDiseaseName.Text.Equals("frontal epithelium"))
                {
                    lblTreatment.Text = "Treatment Details: " + "No-treatment";
                }
                else if (lbtnDiseaseName.Text.Equals("squamous cell carcinoma"))
                {
                    lblTreatment.Text = "Treatment Details: " + "surgery/Streptopenicillin/Melonex";
                }
                else if (lbtnDiseaseName.Text.Equals("nasal granuloma"))
                {
                    lblTreatment.Text = "Treatment Details: " + "nasal-granuloma,dyspnoea,snoring,nodules,oxyclozanide/anthiomaline";
                }
                else if (lbtnDiseaseName.Text.Equals("otitis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "ciprofloxacin-eye-drops/gentamicin/metronidazole/flunimeg";
                }
                else if (lbtnDiseaseName.Text.Equals("gingivitis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "streptopenicillin/oxytetracycline/Boroglycerine/Melonex";
                }



                else if (lbtnDiseaseName.Text.Equals("anthrax"))
                {
                    lblTreatment.Text = "Treatment Details: " + "streptopenicillin/Melonex";
                }
                else if (lbtnDiseaseName.Text.Equals("black quarter"))
                {
                    lblTreatment.Text = "Treatment Details: " + "streptopenicillin/Flunimeg";
                }
                else if (lbtnDiseaseName.Text.Equals("hemorrhagic septicemia"))
                {
                    lblTreatment.Text = "Treatment Details: " + "sulphadimidine/Melonex/CPM/Flunimeg";
                }
                else if (lbtnDiseaseName.Text.Equals("foot and mouth disease"))
                {
                    lblTreatment.Text = "Treatment Details: " + "oxytetracycline/Melonex/Boroglycerine/Neosporin-powder";
                }
                else if (lbtnDiseaseName.Text.Equals("mastitis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "Gentamicin-or-intamox/Mastiwok/flunimeg";
                }
                else if (lbtnDiseaseName.Text.Equals("brucellosis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "";
                }
                else if (lbtnDiseaseName.Text.Equals("bovine malignant catarrhal fever"))
                {
                    lblTreatment.Text = "Treatment Details: " + "streptopenicillin/oxytetracycline";
                }
                else if (lbtnDiseaseName.Text.Equals("babesiosis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "benzathinepenicillin/streptopenicillin/oxytetracycline/Melonex/DNS-5%Dextrose";
                }
                else if (lbtnDiseaseName.Text.Equals("anaplasmosis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "berenil/Melonex/belamyl/tribivet/imferon/mineral-mixture";
                }
                else if (lbtnDiseaseName.Text.Equals("theileriosis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "oxytetracycline/belamyl/tribivet/Melonex";
                }
                else if (lbtnDiseaseName.Text.Equals("trypanosomiasis"))
                {
                    lblTreatment.Text = "Treatment Details: " + "butalex/imferon/tribivet/belamyl/mineral-mixture";
                }
                else if (lbtnDiseaseName.Text.Equals("rabies"))
                {
                    lblTreatment.Text = "Treatment Details: " + "suramin/belamyl/tribivet";
                }
                else
                {
                    lblTreatment.Text = "Invalid Data";
                }

            }
            catch
            {

            }
        }




        static ArrayList _symptoms = new ArrayList();

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton1.Text);
            LinkButton1.Enabled = false;
            LinkButton1.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton2.Text);
            LinkButton2.Enabled = false;
            LinkButton2.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton3.Text);
            LinkButton3.Enabled = false;
            LinkButton3.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton4.Text);
            LinkButton4.Enabled = false;
            LinkButton4.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton5.Text);
            LinkButton5.Enabled = false;
            LinkButton5.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton6.Text);
            LinkButton6.Enabled = false;
            LinkButton6.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton7.Text);
            LinkButton7.Enabled = false;
            LinkButton7.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton8.Text);
            LinkButton8.Enabled = false;
            LinkButton8.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton9.Text);
            LinkButton9.Enabled = false;
            LinkButton9.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton10.Text);
            LinkButton10.Enabled = false;
            LinkButton10.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton11.Text);
            LinkButton11.Enabled = false;
            LinkButton11.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton12.Text);
            LinkButton12.Enabled = false;
            LinkButton12.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton13_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton13.Text);
            LinkButton13.Enabled = false;
            LinkButton13.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton14_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton14.Text);
            LinkButton14.Enabled = false;
            LinkButton14.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton15_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton15.Text);
            LinkButton15.Enabled = false;
            LinkButton15.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton16_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton16.Text);
            LinkButton16.Enabled = false;
            LinkButton16.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton17_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton17.Text);
            LinkButton17.Enabled = false;
            LinkButton17.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton18_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton18.Text);
            LinkButton18.Enabled = false;
            LinkButton18.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton19_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton19.Text);
            LinkButton19.Enabled = false;
            LinkButton19.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton20_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton20.Text);
            LinkButton20.Enabled = false;
            LinkButton20.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton21_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton21.Text);
            LinkButton21.Enabled = false;
            LinkButton21.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton22_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton22.Text);
            LinkButton22.Enabled = false;
            LinkButton22.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton23_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton23.Text);
            LinkButton23.Enabled = false;
            LinkButton23.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton24_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton24.Text);
            LinkButton24.Enabled = false;
            LinkButton24.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton25_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton25.Text);
            LinkButton25.Enabled = false;
            LinkButton25.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton26_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton26.Text);
            LinkButton26.Enabled = false;
            LinkButton26.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton27_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton27.Text);
            LinkButton27.Enabled = false;
            LinkButton27.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton28_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton28.Text);
            LinkButton28.Enabled = false;
            LinkButton28.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton29_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton29.Text);
            LinkButton29.Enabled = false;
            LinkButton29.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton30_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton30.Text);
            LinkButton30.Enabled = false;
            LinkButton30.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton31_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton31.Text);
            LinkButton31.Enabled = false;
            LinkButton31.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton32_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton32.Text);
            LinkButton32.Enabled = false;
            LinkButton32.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton33_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton33.Text);
            LinkButton33.Enabled = false;
            LinkButton33.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton34_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton34.Text);
            LinkButton34.Enabled = false;
            LinkButton34.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton35_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton35.Text);
            LinkButton35.Enabled = false;
            LinkButton35.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton36_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton36.Text);
            LinkButton36.Enabled = false;
            LinkButton36.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton37_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton37.Text);
            LinkButton37.Enabled = false;
            LinkButton37.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton38_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton38.Text);
            LinkButton38.Enabled = false;
            LinkButton38.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton39_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton39.Text);
            LinkButton39.Enabled = false;
            LinkButton39.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton40_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton40.Text);
            LinkButton40.Enabled = false;
            LinkButton40.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton41_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton41.Text);
            LinkButton41.Enabled = false;
            LinkButton41.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton42_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton42.Text);
            LinkButton42.Enabled = false;
            LinkButton42.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton43_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton43.Text);
            LinkButton43.Enabled = false;
            LinkButton43.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton44_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton44.Text);
            LinkButton44.Enabled = false;
            LinkButton44.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton45_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton45.Text);
            LinkButton45.Enabled = false;
            LinkButton45.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton46_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton46.Text);
            LinkButton46.Enabled = false;
            LinkButton46.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton47_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton47.Text);
            LinkButton47.Enabled = false;
            LinkButton47.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton48_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton48.Text);
            LinkButton48.Enabled = false;
            LinkButton48.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton49_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton49.Text);
            LinkButton49.Enabled = false;
            LinkButton49.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton50_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton50.Text);
            LinkButton50.Enabled = false;
            LinkButton50.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtSymptoms.Text = string.Empty;
            LinkButton1.Enabled = LinkButton2.Enabled = LinkButton3.Enabled = LinkButton4.Enabled = LinkButton5.Enabled = LinkButton6.Enabled = LinkButton7.Enabled = LinkButton8.Enabled = LinkButton9.Enabled = LinkButton10.Enabled =
              LinkButton11.Enabled = LinkButton12.Enabled = LinkButton13.Enabled = LinkButton14.Enabled = LinkButton15.Enabled = LinkButton16.Enabled = LinkButton17.Enabled = LinkButton18.Enabled = LinkButton19.Enabled = LinkButton20.Enabled =
                LinkButton21.Enabled = LinkButton22.Enabled = LinkButton23.Enabled = LinkButton24.Enabled = LinkButton25.Enabled = LinkButton26.Enabled = LinkButton27.Enabled = LinkButton28.Enabled = LinkButton29.Enabled = LinkButton30.Enabled =
                  LinkButton31.Enabled = LinkButton32.Enabled = LinkButton33.Enabled = LinkButton34.Enabled = LinkButton35.Enabled = LinkButton36.Enabled = LinkButton37.Enabled = LinkButton38.Enabled = LinkButton39.Enabled = LinkButton40.Enabled =
                    LinkButton41.Enabled = LinkButton42.Enabled = LinkButton43.Enabled = LinkButton44.Enabled = LinkButton45.Enabled = LinkButton46.Enabled = LinkButton47.Enabled = LinkButton48.Enabled = LinkButton49.Enabled = LinkButton50.Enabled =

                      LinkButton51.Enabled = LinkButton52.Enabled = LinkButton53.Enabled = LinkButton54.Enabled = LinkButton55.Enabled = LinkButton56.Enabled = LinkButton57.Enabled = LinkButton58.Enabled = LinkButton59.Enabled = LinkButton60.Enabled =
                        LinkButton61.Enabled = LinkButton62.Enabled = LinkButton63.Enabled = LinkButton64.Enabled = LinkButton65.Enabled = LinkButton66.Enabled = LinkButton67.Enabled = LinkButton68.Enabled = LinkButton69.Enabled = LinkButton70.Enabled =
                          LinkButton71.Enabled = LinkButton72.Enabled = LinkButton73.Enabled = LinkButton74.Enabled = LinkButton75.Enabled = LinkButton76.Enabled = LinkButton77.Enabled = LinkButton78.Enabled = LinkButton79.Enabled = LinkButton80.Enabled =
                            LinkButton81.Enabled = LinkButton82.Enabled = LinkButton83.Enabled = LinkButton84.Enabled = LinkButton85.Enabled = LinkButton86.Enabled = LinkButton87.Enabled = LinkButton88.Enabled = LinkButton89.Enabled = LinkButton90.Enabled =
                              LinkButton91.Enabled = LinkButton92.Enabled = LinkButton93.Enabled = LinkButton94.Enabled = LinkButton95.Enabled = LinkButton96.Enabled = LinkButton97.Enabled = LinkButton98.Enabled = LinkButton99.Enabled = LinkButton100.Enabled =

                                LinkButton101.Enabled = LinkButton102.Enabled = LinkButton103.Enabled = LinkButton104.Enabled = LinkButton105.Enabled = LinkButton106.Enabled = LinkButton107.Enabled = LinkButton108.Enabled = LinkButton109.Enabled = LinkButton110.Enabled =
                                  LinkButton111.Enabled = LinkButton112.Enabled = LinkButton113.Enabled = LinkButton114.Enabled = LinkButton115.Enabled = LinkButton116.Enabled = LinkButton117.Enabled = LinkButton118.Enabled = LinkButton119.Enabled = LinkButton120.Enabled =
                                    LinkButton121.Enabled = LinkButton122.Enabled = LinkButton123.Enabled = LinkButton124.Enabled = LinkButton125.Enabled = LinkButton126.Enabled = LinkButton127.Enabled = LinkButton128.Enabled = LinkButton129.Enabled = LinkButton130.Enabled =
                                      LinkButton131.Enabled = LinkButton132.Enabled = LinkButton133.Enabled = LinkButton134.Enabled = LinkButton135.Enabled = LinkButton136.Enabled = LinkButton137.Enabled = LinkButton138.Enabled = LinkButton139.Enabled = LinkButton140.Enabled =
                                        LinkButton141.Enabled = LinkButton142.Enabled = LinkButton143.Enabled = LinkButton144.Enabled = LinkButton145.Enabled = true;

            Response.Redirect("frmPrediction.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string _inputtedsymptoms = null;

                for (int i = 0; i < _symptoms.Count; i++)
                {
                    _inputtedsymptoms += _symptoms[i].ToString() + ',';
                }

                txtSymptoms.Text = _inputtedsymptoms.Substring(0, _inputtedsymptoms.Length - 1);
            }
            catch
            {

            }
        }

        protected void LinkButton51_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton51.Text);
            LinkButton51.Enabled = false;
            LinkButton51.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton52_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton52.Text);
            LinkButton52.Enabled = false;
            LinkButton52.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton53_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton53.Text);
            LinkButton53.Enabled = false;
            LinkButton53.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton54_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton54.Text);
            LinkButton54.Enabled = false;
            LinkButton54.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton55_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton55.Text);
            LinkButton55.Enabled = false;
            LinkButton55.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton56_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton56.Text);
            LinkButton56.Enabled = false;
            LinkButton56.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton57_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton57.Text);
            LinkButton57.Enabled = false;
            LinkButton57.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton58_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton58.Text);
            LinkButton58.Enabled = false;
            LinkButton58.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton59_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton59.Text);
            LinkButton59.Enabled = false;
            LinkButton59.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton60_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton60.Text);
            LinkButton60.Enabled = false;
            LinkButton60.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton61_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton61.Text);
            LinkButton61.Enabled = false;
            LinkButton61.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton62_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton62.Text);
            LinkButton62.Enabled = false;
            LinkButton62.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton63_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton63.Text);
            LinkButton63.Enabled = false;
            LinkButton63.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton64_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton64.Text);
            LinkButton64.Enabled = false;
            LinkButton64.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton65_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton65.Text);
            LinkButton65.Enabled = false;
            LinkButton65.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton66_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton66.Text);
            LinkButton66.Enabled = false;
            LinkButton66.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton67_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton67.Text);
            LinkButton67.Enabled = false;
            LinkButton67.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton68_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton68.Text);
            LinkButton68.Enabled = false;
            LinkButton68.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton69_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton69.Text);
            LinkButton69.Enabled = false;
            LinkButton69.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton70_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton70.Text);
            LinkButton70.Enabled = false;
            LinkButton70.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton71_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton71.Text);
            LinkButton71.Enabled = false;
            LinkButton71.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton72_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton72.Text);
            LinkButton72.Enabled = false;
            LinkButton72.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton73_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton73.Text);
            LinkButton73.Enabled = false;
            LinkButton73.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton74_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton74.Text);
            LinkButton74.Enabled = false;
            LinkButton74.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton75_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton75.Text);
            LinkButton75.Enabled = false;
            LinkButton75.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton76_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton76.Text);
            LinkButton76.Enabled = false;
            LinkButton76.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton77_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton77.Text);
            LinkButton77.Enabled = false;
            LinkButton77.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton78_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton78.Text);
            LinkButton78.Enabled = false;
            LinkButton78.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton79_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton79.Text);
            LinkButton79.Enabled = false;
            LinkButton79.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton80_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton80.Text);
            LinkButton80.Enabled = false;
            LinkButton80.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton81_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton81.Text);
            LinkButton81.Enabled = false;
            LinkButton81.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton82_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton82.Text);
            LinkButton82.Enabled = false;
            LinkButton82.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton83_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton83.Text);
            LinkButton83.Enabled = false;
            LinkButton83.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton84_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton84.Text);
            LinkButton84.Enabled = false;
            LinkButton84.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton85_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton85.Text);
            LinkButton85.Enabled = false;
            LinkButton85.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton86_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton86.Text);
            LinkButton86.Enabled = false;
            LinkButton86.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton87_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton87.Text);
            LinkButton87.Enabled = false;
            LinkButton87.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton88_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton88.Text);
            LinkButton88.Enabled = false;
            LinkButton88.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton89_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton89.Text);
            LinkButton89.Enabled = false;
            LinkButton89.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton90_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton90.Text);
            LinkButton90.Enabled = false;
            LinkButton90.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton91_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton91.Text);
            LinkButton91.Enabled = false;
            LinkButton91.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton92_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton92.Text);
            LinkButton92.Enabled = false;
            LinkButton92.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton93_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton93.Text);
            LinkButton93.Enabled = false;
            LinkButton93.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton94_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton94.Text);
            LinkButton94.Enabled = false;
            LinkButton94.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton95_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton95.Text);
            LinkButton95.Enabled = false;
            LinkButton95.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton96_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton96.Text);
            LinkButton96.Enabled = false;
            LinkButton96.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton97_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton97.Text);
            LinkButton97.Enabled = false;
            LinkButton97.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton98_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton98.Text);
            LinkButton98.Enabled = false;
            LinkButton98.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton99_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton99.Text);
            LinkButton99.Enabled = false;
            LinkButton99.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton100_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton100.Text);
            LinkButton100.Enabled = false;
            LinkButton100.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton101_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton101.Text);
            LinkButton101.Enabled = false;
            LinkButton101.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton102_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton102.Text);
            LinkButton102.Enabled = false;
            LinkButton102.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton103_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton103.Text);
            LinkButton103.Enabled = false;
            LinkButton103.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton104_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton104.Text);
            LinkButton104.Enabled = false;
            LinkButton104.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton105_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton105.Text);
            LinkButton105.Enabled = false;
            LinkButton105.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton106_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton106.Text);
            LinkButton106.Enabled = false;
            LinkButton106.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton107_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton107.Text);
            LinkButton107.Enabled = false;
            LinkButton107.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton108_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton108.Text);
            LinkButton108.Enabled = false;
            LinkButton108.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton109_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton109.Text);
            LinkButton109.Enabled = false;
            LinkButton109.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton110_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton110.Text);
            LinkButton110.Enabled = false;
            LinkButton110.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton111_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton111.Text);
            LinkButton111.Enabled = false;
            LinkButton111.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton112_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton112.Text);
            LinkButton112.Enabled = false;
            LinkButton112.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton113_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton113.Text);
            LinkButton113.Enabled = false;
            LinkButton113.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton114_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton114.Text);
            LinkButton114.Enabled = false;
            LinkButton114.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton115_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton115.Text);
            LinkButton115.Enabled = false;
            LinkButton115.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton116_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton116.Text);
            LinkButton116.Enabled = false;
            LinkButton116.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton117_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton117.Text);
            LinkButton117.Enabled = false;
            LinkButton117.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton118_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton118.Text);
            LinkButton118.Enabled = false;
            LinkButton118.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton119_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton119.Text);
            LinkButton119.Enabled = false;
            LinkButton119.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton120_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton120.Text);
            LinkButton120.Enabled = false;
            LinkButton120.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton121_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton121.Text);
            LinkButton121.Enabled = false;
            LinkButton121.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton122_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton122.Text);
            LinkButton122.Enabled = false;
            LinkButton122.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton123_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton123.Text);
            LinkButton123.Enabled = false;
            LinkButton123.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton124_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton124.Text);
            LinkButton124.Enabled = false;
            LinkButton124.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton125_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton125.Text);
            LinkButton125.Enabled = false;
            LinkButton125.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton126_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton126.Text);
            LinkButton126.Enabled = false;
            LinkButton126.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton127_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton127.Text);
            LinkButton127.Enabled = false;
            LinkButton127.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton128_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton128.Text);
            LinkButton128.Enabled = false;
            LinkButton128.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton129_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton129.Text);
            LinkButton129.Enabled = false;
            LinkButton129.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton130_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton130.Text);
            LinkButton130.Enabled = false;
            LinkButton130.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton131_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton131.Text);
            LinkButton131.Enabled = false;
            LinkButton131.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton132_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton132.Text);
            LinkButton132.Enabled = false;
            LinkButton132.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton133_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton133.Text);
            LinkButton133.Enabled = false;
            LinkButton133.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton134_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton134.Text);
            LinkButton134.Enabled = false;
            LinkButton134.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton135_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton135.Text);
            LinkButton135.Enabled = false;
            LinkButton135.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton136_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton136.Text);
            LinkButton136.Enabled = false;
            LinkButton136.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton137_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton137.Text);
            LinkButton137.Enabled = false;
            LinkButton137.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton138_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton138.Text);
            LinkButton138.Enabled = false;
            LinkButton138.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton139_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton139.Text);
            LinkButton139.Enabled = false;
            LinkButton139.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton140_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton140.Text);
            LinkButton140.Enabled = false;
            LinkButton140.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton141_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton141.Text);
            LinkButton141.Enabled = false;
            LinkButton141.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton142_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton142.Text);
            LinkButton142.Enabled = false;
            LinkButton142.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton143_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton143.Text);
            LinkButton143.Enabled = false;
            LinkButton143.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton144_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton144.Text);
            LinkButton144.Enabled = false;
            LinkButton144.ForeColor = System.Drawing.Color.DarkGreen;
        }

        protected void LinkButton145_Click(object sender, EventArgs e)
        {
            _symptoms.Add(LinkButton145.Text);
            LinkButton145.Enabled = false;
            LinkButton145.ForeColor = System.Drawing.Color.DarkGreen;
        }
    }
}