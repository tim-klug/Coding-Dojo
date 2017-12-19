using System;
using FluentAssertions;
using LightBDD.Framework;
using LightBDD.Framework.Scenarios.Basic;
using LightBDD.NUnit3;
using NUnit.Framework;

namespace BankAccountKata.BddTests.BankAccount
{
    [TestFixture]
    [FeatureDescription(@"Ich als Besucher
wähle eine Vorstellung aus
um den Film zu sehen.")]
    [Label("UserStory - #1")]
    public partial class Ticket_Kaufen_Test
    {
        [Scenario]
        [Label("QM4711")]
        [ScenarioCategory("Film Reservierung")]
        public void Film_aussuchen()
        {
            Runner.RunScenario(
                Given_ein_Datum,
                Given_eine_Uhrzeit,
                Given_ein_Film,
                When_es_eine_Vorstellung_mit_freien_Plaetzen_gibt,
                When_die_Verfuegbarkeit_geprueft_wird,
                Then_die_Anzahl_der_freien_Plaetze_wird_angezeigt
            );
        }
    }

    public partial class Ticket_Kaufen_Test : FeatureFixture
    {
        private DateTime _Zeitpunkt;
        private Film _Film;
        private Vorstellung _Vorstellung;

        private void Given_ein_Datum()
        {
            _Zeitpunkt = DateTime.Now;
        }

        private void Given_eine_Uhrzeit()
        {
        }

        private void Given_ein_Film()
        {
            _Film = new Film();
        }

        private void When_es_eine_Vorstellung_mit_freien_Plaetzen_gibt()
        {
            _Vorstellung = new Vorstellung();
            _Vorstellung.FreiePlaetze = 10;
        }

        private void When_die_Verfuegbarkeit_geprueft_wird()
        {
            _Vorstellung.PruefeVerfuegbarkeit();
        }

        private void Then_die_Anzahl_der_freien_Plaetze_wird_angezeigt()
        {
            _Vorstellung.FreiePlaetze.Should().Be(10);
        }
    }

    internal class Vorstellung
    {
        public Vorstellung()
        {
        }

        public int FreiePlaetze { get; internal set; }

        internal bool PruefeVerfuegbarkeit()
        {
            return FreiePlaetze > 0;
        }
    }

    public class Film
        {
            public Film()
            {
            }
    }
}