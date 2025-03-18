using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum States
    {
        Start,
        Arrival,
        Inside,
        Outside,
        GroupExploration,
        ExploringBasement,
        ForestSecrets,
        HauntedWaters,
        UnearthingClues,
        GhostlyDinner,
        MysteriousMemories,
        WhisperingTrees,
        SignsOfThePast,
        ReflectionsOfFear,
        FrozenDepths,
        Regrouping,
        SecretsRevealed,
        MappingUnknown,
        DinnerParty,
        VoiceOfThePast,
        LostPath,
        HauntingVision,
        UnseenDangers,
        UnitingAgainstDarkness,
        DistrustAndDivision,  // Added state
        Resolution
    }

    private States currentState;

    void Start()
    {
        currentState = States.Start;
        Terminal.WriteLine("Typ 'start' om te beginnen");
    }

    private void OnUserInput(string input)
    {
        string userInput = input.ToLower();

        switch (currentState)
        {
            case States.Start:
                if (userInput == "start")
                {
                    currentState = States.Arrival;
                    Arrival();
                }
                break;

            case States.Arrival:
                if (userInput == "enter")
                {
                    currentState = States.Inside;
                    InsideResort();
                }
                else if (userInput == "explore")
                {
                    currentState = States.Outside;
                    OutsideResort();
                }
                break;

            case States.Inside:
                if (userInput == "stay together")
                {
                    currentState = States.GroupExploration;
                    GroupExploration();
                }
                else if (userInput == "split up")
                {
                    currentState = States.ExploringBasement;
                    ExploringBasement();
                }
                break;

            case States.Outside:
                if (userInput == "investigate woods")
                {
                    currentState = States.ForestSecrets;
                    ForestSecrets();
                }
                else if (userInput == "explore lake")
                {
                    currentState = States.HauntedWaters;
                    HauntedWaters();
                }
                break;

            case States.GroupExploration:
                if (userInput == "search lobby")
                {
                    currentState = States.UnearthingClues;
                    UnearthingClues();
                }
                else if (userInput == "check dining hall")
                {
                    currentState = States.GhostlyDinner;
                    GhostlyDinner();
                }
                break;

            case States.ExploringBasement:
                if (userInput == "examine photographs")
                {
                    currentState = States.MysteriousMemories;
                    MysteriousMemories();
                }
                else if (userInput == "leave basement")
                {
                    currentState = States.Regrouping;
                    Regrouping();
                }
                break;

            case States.ForestSecrets:
                if (userInput == "follow noises")
                {
                    currentState = States.WhisperingTrees;
                    WhisperingTrees();
                }
                else if (userInput == "search tracks")
                {
                    currentState = States.SignsOfThePast;
                    SignsOfThePast();
                }
                break;

            case States.HauntedWaters:
                if (userInput == "skim stones")
                {
                    currentState = States.ReflectionsOfFear;
                    ReflectionsOfFear();
                }
                else if (userInput == "investigate crack")
                {
                    currentState = States.FrozenDepths;
                    FrozenDepths();
                }
                break;

            case States.UnearthingClues:
                if (userInput == "find diary")
                {
                    currentState = States.SecretsRevealed;
                    SecretsRevealed();
                }
                else if (userInput == "discover map")
                {
                    currentState = States.MappingUnknown;
                    MappingUnknown();
                }
                break;

            case States.GhostlyDinner:
                if (userInput == "set table")
                {
                    currentState = States.DinnerParty;
                    DinnerParty();
                }
                else if (userInput == "leave dining hall")
                {
                    currentState = States.Regrouping;
                    Regrouping();
                }
                break;

            case States.MysteriousMemories:
                if (userInput == "read diary")
                {
                    currentState = States.SecretsRevealed;
                    SecretsRevealed();
                }
                else if (userInput == "search items")
                {
                    currentState = States.Regrouping;
                    Regrouping();
                }
                break;

            case States.WhisperingTrees:
                if (userInput == "call out")
                {
                    currentState = States.VoiceOfThePast;
                    VoiceOfThePast();
                }
                else if (userInput == "ignore")
                {
                    currentState = States.Regrouping;
                    Regrouping();
                }
                break;

            case States.SignsOfThePast:
                if (userInput == "follow tracks")
                {
                    currentState = States.LostPath;
                    LostPath();
                }
                else if (userInput == "turn back")
                {
                    currentState = States.Regrouping;
                    Regrouping();
                }
                break;

            case States.ReflectionsOfFear:
                if (userInput == "look into water")
                {
                    currentState = States.HauntingVision;
                    HauntingVision();
                }
                else if (userInput == "walk away")
                {
                    currentState = States.Regrouping;
                    Regrouping();
                }
                break;

            case States.FrozenDepths:
                if (userInput == "investigate further")
                {
                    currentState = States.UnseenDangers;
                    UnseenDangers();
                }
                else if (userInput == "retreat")
                {
                    currentState = States.Regrouping;
                    Regrouping();
                }
                break;

            case States.Regrouping:
                if (userInput == "share findings")
                {
                    currentState = States.UnitingAgainstDarkness;
                    UnitingAgainstDarkness();
                }
                else if (userInput == "keep secrets")
                {
                    currentState = States.DistrustAndDivision; // Added this line
                    DistrustAndDivision();
                }
                break;

            case States.SecretsRevealed:
                if (userInput == "confront group")
                {
                    currentState = States.UnitingAgainstDarkness;
                    UnitingAgainstDarkness();
                }
                else if (userInput == "hide diary")
                {
                    currentState = States.DistrustAndDivision;
                    DistrustAndDivision();
                }
                break;

            case States.MappingUnknown:
                if (userInput == "explore areas")
                {
                    currentState = States.UnitingAgainstDarkness;
                    UnitingAgainstDarkness();
                }
                else if (userInput == "ignore map")
                {
                    currentState = States.DistrustAndDivision;
                    DistrustAndDivision();
                }
                break;

            case States.DinnerParty:
                if (userInput == "set up dinner")
                {
                    currentState = States.UnitingAgainstDarkness;
                    UnitingAgainstDarkness();
                }
                else if (userInput == "leave abruptly")
                {
                    currentState = States.DistrustAndDivision;
                    DistrustAndDivision();
                }
                break;

            case States.VoiceOfThePast:
                if (userInput == "listen")
                {
                    currentState = States.UnitingAgainstDarkness;
                    UnitingAgainstDarkness();
                }
                else if (userInput == "disregard")
                {
                    currentState = States.DistrustAndDivision;
                    DistrustAndDivision();
                }
                break;

            case States.LostPath:
                if (userInput == "follow path")
                {
                    currentState = States.UnitingAgainstDarkness;
                    UnitingAgainstDarkness();
                }
                else if (userInput == "turn back")
                {
                    currentState = States.DistrustAndDivision;
                    DistrustAndDivision();
                }
                break;

            case States.HauntingVision:
                if (userInput == "confront vision")
                {
                    currentState = States.UnitingAgainstDarkness;
                    UnitingAgainstDarkness();
                }
                else if (userInput == "ignore")
                {
                    currentState = States.DistrustAndDivision;
                    DistrustAndDivision();
                }
                break;

            case States.UnseenDangers:
                if (userInput == "investigate")
                {
                    currentState = States.DistrustAndDivision; // Possible death
                    DistrustAndDivision();
                }
                else if (userInput == "retreat")
                {
                    currentState = States.Regrouping;
                    Regrouping();
                }
                break;

            case States.UnitingAgainstDarkness:
                // Handle the resolution or conclusion of the game here
                ShowResolution(true); // or false based on player choices
                break;

            case States.DistrustAndDivision:
                if (userInput == "talk")
                {
                    currentState = States.Regrouping; // Reunite the group
                    Regrouping();
                }
                else if (userInput == "leave")
                {
                    currentState = States.Resolution; // This could lead to a bad ending
                    ShowResolution(false);
                }
                break;
        }
    }

    private void Arrival()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je arriveert bij het vervloekte resort.");
        Terminal.WriteLine("Typ 'enter' om naar binnen te gaan of 'explore' om buiten te verkennen.");
        Terminal.WriteLine("Keuzes: 'enter' of 'explore'");
    }

    private void InsideResort()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je staat in de lobby van het resort. Wil je samenblijven of je splitsen?");
        Terminal.WriteLine("Typ 'stay together' om samen te blijven of 'split up' om je te splitsen.");
        Terminal.WriteLine("Keuzes: 'stay together' of 'split up'");
    }

    private void OutsideResort()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Buiten is er een bos aan de linkerkant en een meer aan de rechterkant. Waar ga je naartoe?");
        Terminal.WriteLine("Typ 'investigate woods' om naar het bos te gaan of 'explore lake' om naar het meer te gaan.");
        Terminal.WriteLine("Keuzes: 'investigate woods' of 'explore lake'");
    }

    private void GroupExploration()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je besluit om samen te verkennen. Wat ga je zoeken?");
        Terminal.WriteLine("Typ 'search lobby' om aanwijzingen te zoeken of 'check dining hall' om de eetzaal te controleren.");
        Terminal.WriteLine("Keuzes: 'search lobby' of 'check dining hall'");
    }

    private void ExploringBasement()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je gaat naar de kelder. Wat ga je doen?");
        Terminal.WriteLine("Typ 'examine photographs' om foto's te onderzoeken of 'leave basement' om terug te gaan.");
        Terminal.WriteLine("Keuzes: 'examine photographs' of 'leave basement'");
    }

    private void ForestSecrets()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je verken het bos en hoort vreemde geluiden. Wat ga je doen?");
        Terminal.WriteLine("Typ 'follow noises' om de geluiden te volgen of 'search tracks' om naar sporen te zoeken.");
        Terminal.WriteLine("Keuzes: 'follow noises' of 'search tracks'");
    }

    private void HauntedWaters()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je kijkt naar het meer. Wat ga je doen?");
        Terminal.WriteLine("Typ 'skim stones' om stenen over het water te laten springen of 'investigate crack' om de scheur te onderzoeken.");
        Terminal.WriteLine("Keuzes: 'skim stones' of 'investigate crack'");
    }

    private void UnearthingClues()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je zoekt naar aanwijzingen in de lobby. Wat ga je vinden?");
        Terminal.WriteLine("Typ 'find diary' om het dagboek te zoeken of 'discover map' om een kaart te vinden.");
        Terminal.WriteLine("Keuzes: 'find diary' of 'discover map'");
    }

    private void GhostlyDinner()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je ontdekt een mysterieuze maaltijd in de eetzaal. Wat ga je doen?");
        Terminal.WriteLine("Typ 'set table' om de tafel te dekken of 'leave dining hall' om weg te gaan.");
        Terminal.WriteLine("Keuzes: 'set table' of 'leave dining hall'");
    }

    private void MysteriousMemories()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je vindt foto's die herinneringen oproepen. Wat ga je doen?");
        Terminal.WriteLine("Typ 'read diary' om het dagboek te lezen of 'search items' om andere voorwerpen te onderzoeken.");
        Terminal.WriteLine("Keuzes: 'read diary' of 'search items'");
    }

    private void WhisperingTrees()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("De bomen lijken te fluisteren. Wat ga je doen?");
        Terminal.WriteLine("Typ 'call out' om te roepen of 'ignore' om het te negeren.");
        Terminal.WriteLine("Keuzes: 'call out' of 'ignore'");
    }

    private void SignsOfThePast()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je vindt sporen die naar het verleden wijzen. Wat ga je doen?");
        Terminal.WriteLine("Typ 'follow tracks' om de sporen te volgen of 'turn back' om terug te keren.");
        Terminal.WriteLine("Keuzes: 'follow tracks' of 'turn back'");
    }

    private void ReflectionsOfFear()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je kijkt in het water en ziet je angsten weerspiegeld. Wat ga je doen?");
        Terminal.WriteLine("Typ 'look into water' om in het water te kijken of 'walk away' om weg te lopen.");
        Terminal.WriteLine("Keuzes: 'look into water' of 'walk away'");
    }

    private void FrozenDepths()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je ontdekt een diepere laag van het meer. Wat ga je doen?");
        Terminal.WriteLine("Typ 'investigate further' om verder te onderzoeken of 'retreat' om terug te gaan.");
        Terminal.WriteLine("Keuzes: 'investigate further' of 'retreat'");
    }

    private void Regrouping()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je komt weer bij elkaar. Wat ga je delen?");
        Terminal.WriteLine("Typ 'share findings' om je bevindingen te delen of 'keep secrets' om geheimen te bewaren.");
        Terminal.WriteLine("Keuzes: 'share findings' of 'keep secrets'");
    }

    private void SecretsRevealed()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Er zijn geheimen onthuld. Wat ga je nu doen?");
        Terminal.WriteLine("Typ 'confront group' om de groep te confronteren of 'hide diary' om het dagboek te verbergen.");
        Terminal.WriteLine("Keuzes: 'confront group' of 'hide diary'");
    }

    private void MappingUnknown()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je vindt een kaart van onbekende gebieden. Wat ga je doen?");
        Terminal.WriteLine("Typ 'explore areas' om de gebieden te verkennen of 'ignore map' om de kaart te negeren.");
        Terminal.WriteLine("Keuzes: 'explore areas' of 'ignore map'");
    }

    private void DinnerParty()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je organiseert een diner. Wat ga je doen?");
        Terminal.WriteLine("Typ 'set up dinner' om het diner op te zetten of 'leave abruptly' om abrupt weg te gaan.");
        Terminal.WriteLine("Keuzes: 'set up dinner' of 'leave abruptly'");
    }

    private void VoiceOfThePast()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hoort stemmen uit het verleden. Wat ga je doen?");
        Terminal.WriteLine("Typ 'listen' om te luisteren of 'disregard' om het te negeren.");
        Terminal.WriteLine("Keuzes: 'listen' of 'disregard'");
    }

    private void LostPath()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je verliest het pad. Wat ga je doen?");
        Terminal.WriteLine("Typ 'follow path' om het pad te volgen of 'turn back' om terug te keren.");
        Terminal.WriteLine("Keuzes: 'follow path' of 'turn back'");
    }

    private void HauntingVision()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt een angstaanjagende visie. Wat ga je doen?");
        Terminal.WriteLine("Typ 'confront vision' om het onder ogen te zien of 'ignore' om weg te rennen.");
        Terminal.WriteLine("Keuzes: 'confront vision' of 'ignore'");
    }

    private void UnseenDangers()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je voelt een onzichtbaar gevaar. Wat ga je doen?");
        Terminal.WriteLine("Typ 'investigate' om te onderzoeken of 'retreat' om weg te gaan.");
        Terminal.WriteLine("Keuzes: 'investigate' of 'retreat'");
    }

    private void UnitingAgainstDarkness()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je groep komt samen om de duisternis te bestrijden. Wat ga je doen?");
        Terminal.WriteLine("Typ 'attack' om aan te vallen of 'strategize' om een plan te maken.");
        Terminal.WriteLine("Keuzes: 'attack' of 'strategize'");
    }

    private void DistrustAndDivision()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Er is wantrouwen en verdeeldheid in de groep. Wat ga je nu doen?");
        Terminal.WriteLine("Typ 'talk' om te praten of 'leave' om de groep te verlaten.");
        Terminal.WriteLine("Keuzes: 'talk' of 'leave'");
    }

    private void ShowResolution(bool success)
    {
        Terminal.ClearScreen();
        if (success)
        {
            Terminal.WriteLine("Je hebt de duisternis overwonnen en de geesten bevrijd!");
        }
        else
        {
            Terminal.WriteLine("Je hebt de groep gesplitst en de duisternis overwonnen, maar niet zonder offers.");
        }
        Terminal.WriteLine("Typ 'restart' om opnieuw te beginnen of 'quit' om het spel te beëindigen.");
    }


}
