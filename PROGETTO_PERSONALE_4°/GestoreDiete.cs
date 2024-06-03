using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGETTO_PERSONALE_4_
{
    public class GestoreDiete
    {
        private List<Dieta> diete;

        // Costruttore per inizializzare le dietee
        public GestoreDiete()
        {
            diete = InizializzaDiete();
        }

        // Metodo per inizializzare le diete con le informazioni fornite
        private List<Dieta> InizializzaDiete()
        {
            List<Dieta> diete = new List<Dieta>();

            // Dieta da 1000 - 1500 calorie
            Dieta dieta1000_1500 = new Dieta(
                "Dieta da 1000 - 1500 calorie",
                new List<string>
                {
                "Opzione 1: Yogurt greco (150g) con miele (1 cucchiaino) e fragole (50g).",
                "Opzione 2: Porridge d'avena (30g) con latte scremato (200ml), banana (mezza) e semi di chia (1 cucchiaino).",
                "Opzione 3: Pane integrale (1 fetta) con avocado (mezzo) e pomodoro (1)."
                },
                new List<string>
                {
                "Opzione 1: Una mela.",
                "Opzione 2: Carote (100g) con hummus (2 cucchiai).",
                "Opzione 3: Una piccola barretta di cereali integrali (circa 100 kcal)."
                },
                new List<string>
                {
                "Opzione 1: Insalata di quinoa (50g cotta) con verdure grigliate (150g), ceci (50g) e feta (20g).",
                "Opzione 2: Panino integrale con tacchino (50g), lattuga, pomodoro e avocado (30g).",
                "Opzione 3: Zuppa di lenticchie (200ml) con una fetta di pane integrale."
                },
                new List<string>
                {
                "Opzione 1: Un frutto fresco (come una banana).",
                "Opzione 2: Yogurt naturale (125g) con miele (1 cucchiaino).",
                "Opzione 3: Bastoncini di sedano (100g) con burro di mandorle (1 cucchiaino)."
                },
                new List<string>
                {
                "Opzione 1: Filetto di salmone al forno (100g) con contorno di broccoli al vapore (150g) e quinoa (50g cotta).",
                "Opzione 2: Pollo alla griglia (100g) con patate dolci arrosto (100g) e insalata mista (100g).",
                "Opzione 3: Pasta integrale (60g) con salsa di pomodoro (100g), spinaci freschi (50g) e parmigiano (10g)."
                }
            );

            // Dieta da 1500 - 2000 calorie
            Dieta dieta1500_2000 = new Dieta(
                "Dieta da 1500 - 2000 calorie",
                new List<string>
                {
                "Opzione 1: Yogurt greco (200g) con miele (2 cucchiaini) e frutta fresca (100g).",
                "Opzione 2: Porridge d'avena (50g) con latte scremato (250ml), banana (1) e semi di chia (1 cucchiaino).",
                "Opzione 3: Pane integrale (2 fette) con avocado (1) e pomodoro (1)."
                },
                new List<string>
                {
                "Opzione 1: Una mela con un cucchiaio di burro di arachidi.",
                "Opzione 2: Carote (150g) e hummus (3 cucchiaai).",
                "Opzione 3: Una barretta di cereali integrali (circa 150 kcal)."
            },
            new List<string>
            {
                "Opzione 1: Insalata di quinoa (70g cotta) con verdure grigliate (200g), ceci (70g) e feta (30g).",
                "Opzione 2: Panino integrale con tacchino (70g), lattuga, pomodoro e avocado (50g).",
                "Opzione 3: Zuppa di lenticchie (300ml) con due fette di pane integrale."
            },
            new List<string>
            {
                "Opzione 1: Un frutto fresco (come una banana o una pera) e una manciata di mandorle (20g).",
                "Opzione 2: Yogurt naturale (150g) con miele (1 cucchiaino) e semi di lino (1 cucchiaino).",
                "Opzione 3: Bastoncini di sedano (150g) con burro di mandorle (1 cucchiaino)."
            },
            new List<string>
            {
                "Opzione 1: Filetto di salmone al forno (150g) con contorno di broccoli al vapore (200g) e quinoa (70g cotta).",
                "Opzione 2: Pollo alla griglia (150g) con patate dolci arrosto (150g) e insalata mista (150g).",
                "Opzione 3: Pasta integrale (80g) con salsa di pomodoro (150g), spinaci freschi (70g) e parmigiano (15g)."
            }
        );




            // Dieta da 2000 - 2500 calorie
            Dieta dieta2000_2500 = new Dieta(
                "Dieta da 2000 - 2500 calorie",
                new List<string>
                {
                "Opzione 1: Yogurt greco (250g) con miele (2 cucchiaini) e frutta fresca (150g).",
                "Opzione 2: Porridge d'avena (70g) con latte scremato (300ml), banana (1) e semi di chia (2 cucchiaini).",
                "Opzione 3: Pane integrale(3 fette) con avocado(1) e pomodoro(1)."
                },
                new List<string>
                {
                "Opzione 1: Una mela con due cucchiai di burro di arachidi.",
                "Opzione 2: Carote (200g) e hummus (3 cucchiai).",
                "Opzione 3: Una barretta di cereali integrali (circa 200 kcal)."
            },
            new List<string>
            {
                "Opzione 1: Insalata di quinoa (100g cotta) con verdure grigliate (250g), ceci (100g) e feta (40g).",
                "Opzione 2: Panino integrale con tacchino (100g), lattuga, pomodoro e avocado (70g).",
                "Opzione 3: Zuppa di lenticchie (400ml) con due fette di pane integrale."
            },
            new List<string>
            {
                "Opzione 1: Un frutto fresco (come una banana o una pera) e una manciata di mandorle (30g).",
                "Opzione 2: Yogurt naturale (200g) con miele (1 cucchiaino) e semi di lino (1 cucchiaino).",
                "Opzione 3: Bastoncini di sedano (200g) con burro di mandorle (2 cucchiaini)."
            },
            new List<string>
            {
                "Opzione 1: Filetto di salmone al forno (200g) con contorno di broccoli al vapore (250g) e quinoa (100g cotta).",
                "Opzione 2: Pollo alla griglia (200g) con patate dolci arrosto (200g) e insalata mista (200g).",
                "Opzione 3: Pasta integrale (100g) con salsa di pomodoro (200g), spinaci freschi (100g) e parmigiano (20g)."
            }
        );





            // Dieta da 2500 - 3000 calorie
            Dieta dieta2500_3000 = new Dieta(
                "Dieta da 2500 - 3000 calorie",
                new List<string>
                {
                "Opzione 1: Yogurt greco (300g) con miele (3 cucchiaini) e frutta fresca (200g).",
                "Opzione 2: Porridge d'avena (70g) con latte scremato (300ml), banana (1) e semi di chia (2 cucchiaini).",
                "Opzione 3: Pane integrale (3 fette) con avocado (1) e pomodoro (2)."
                },
                new List<string>
                {
                "Opzione 1: Una mela con due cucchiai di burro di arachidi.",
                "Opzione 2: Carote (200g) e hummus (4 cucchiai).",
                "Opzione 3: Una barretta di cereali integrali (circa 250 kcal)."
            },
            new List<string>
            {
                "Opzione 1: Insalata di quinoa (120g cotta) con verdure grigliate (300g), ceci (120g) e feta (50g).",
                "Opzione 2: Panino integrale con tacchino (120g), lattuga, pomodoro e avocado (80g).",
                "Opzione 3: Zuppa di lenticchie (500ml) con tre fette di pane integrale."
            },
            new List<string>
            {
                "Opzione 1: Un frutto fresco (come una banana o una pera) e una manciata di mandorle (40g).",
                "Opzione 2: Yogurt naturale (250g) con miele (2 cucchiaini) e semi di lino (2 cucchiaini).",
                "Opzione 3: Bastoncini di sedano (250g) con burro di mandorle (2 cucchiaini)."
            },
            new List<string>
            {
                "Opzione 1: Filetto di salmone al forno (250g) con contorno di broccoli al vapore (300g) e quinoa (120g cotta).",
                "Opzione 2: Pollo alla griglia (250g) con patate dolci arrosto (250g) e insalata mista (250g).",
                "Opzione 3: Pasta integrale (120g) con salsa di pomodoro (250g), spinaci freschi (120g) e parmigiano (25g)."
            }
        );



            //Aggiungi le diete alla lista diete
            diete.Add(dieta1000_1500);
            diete.Add(dieta1500_2000);
            diete.Add(dieta2000_2500);
            diete.Add(dieta2500_3000);

            //Restituzione della lista di diete inizializzat
            return diete;
        }

        public Dieta SelezionaDieta(int fabbisognoCalorico)
        {
            // Implementazione della logica per selezionare la dieta
            if (fabbisognoCalorico >= 1000 && fabbisognoCalorico <= 1500)
            {
                // Restituisci la dieta con fabbisogno calorico compreso tra 1000 e 1500
                return diete.Find(d => d.Nome == "Dieta da 1000 - 1500 calorie");
            }
            else if (fabbisognoCalorico > 1500 && fabbisognoCalorico <= 2000)
            {
                // Restituisci la dieta con fabbisogno calorico compreso tra 1500 e 2000
                return diete.Find(d => d.Nome == "Dieta da 1500 - 2000 calorie");
            }
            else if (fabbisognoCalorico > 2000 && fabbisognoCalorico <= 2500)
            {
                // Restituisci la dieta con fabbisogno calorico compreso tra 2000 e 2500
                return diete.Find(d => d.Nome == "Dieta da 2000 - 2500 calorie");
            }
            else if (fabbisognoCalorico > 2500 && fabbisognoCalorico <= 3000)
            {
                // Restituisci la dieta con fabbisogno calorico compreso tra 2500 e 3000
                return diete.Find(d => d.Nome == "Dieta da 2500 - 3000 calorie");
            }
            else
            {
                // Se il fabbisogno calorico non rientra in nessun intervallo, restituisci null
                return null;
            }
        }
    }
}
