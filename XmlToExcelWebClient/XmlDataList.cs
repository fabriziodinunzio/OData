using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XmlToExcelWebClient
{
    public class XmlDataList
    {
		public String[] Xml 
		{
			get => new string[]
			{
				@"<Applicazione xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd='http://www.w3.org/2001/XMLSchema'>
				<Id>0</Id>
				<DtInsert>2020-02-21T12:48:22.7541586+01:00</DtInsert>
				<DtUpdate>2020-02-21T12:48:22.7601621+01:00</DtUpdate>
						<IdApplicazione>6</IdApplicazione>
						<IdTipologiaApplicazione>10</IdTipologiaApplicazione>
						<IdAreaApplicativa>10</IdAreaApplicativa>
						<DescApplicazione>Test File Excel</DescApplicazione>
						<IdReferente>3</IdReferente>
						<IdTipologiaReferente>7</IdTipologiaReferente>
						<IdPerimetroLivello1>10</IdPerimetroLivello1>
						<IdPerimetroLivello2>10</IdPerimetroLivello2>
						<IdPerimetroLivello3>10</IdPerimetroLivello3>
						<DescrizioneEstesa>Questa applicazione serve per tante cose</DescrizioneEstesa>
						<IdNumeroUtenti>50</IdNumeroUtenti>
						<AnnoImplementazione>2040</AnnoImplementazione>
						<AnnoDismissione>2020</AnnoDismissione>
						<IdStatoApplicazione>30</IdStatoApplicazione>
						<FlgServizioEsternalizzato>true</FlgServizioEsternalizzato>
						<IdSocietaVendor>20</IdSocietaVendor>
						<IdSocietaAM>20</IdSocietaAM>
						<FlgQRadarLogSource>false</FlgQRadarLogSource>
						<IdTipologiaLog>10</IdTipologiaLog>
						<IdModalitaAccesso>50</IdModalitaAccesso>
						<IdLinguaggioProgrUI>30</IdLinguaggioProgrUI>
						<IdLinguaggioProgrAL>70</IdLinguaggioProgrAL>
						<IdDataLayer>20</IdDataLayer>
						<Interfacce>MMMMMGGGGGOOOOO</Interfacce>
						<AltreInfo>ALTRE INFO</AltreInfo>
						<FlgRilevanzaBIA>true</FlgRilevanzaBIA>
						<FlgRilevanzaRISK>false</FlgRilevanzaRISK>
						<FlgRilevanzaSicurezza>true</FlgRilevanzaSicurezza>
						<DescAreaApplicativa>Harpo</DescAreaApplicativa>
						<DescTipologiaApplicazione>PPPP</DescTipologiaApplicazione>
						<DescPerimetroLivello1>1 - Accesso</DescPerimetroLivello1>
						<DescPerimetroLivello2>1.1 - Interno</DescPerimetroLivello2>
						<DescPerimetroLivello3>1.1.1 - Intranet</DescPerimetroLivello3>
						<DescNumeroUtenti>51-100</DescNumeroUtenti>
						<DescStatoApplicazione>In progettazione</DescStatoApplicazione>
						<DescDataLayer>DataLayer</DescDataLayer>
						<DescLinguaggioProgrammazioneUi>UI Programming</DescLinguaggioProgrammazioneUi>
						<DescLinguaggioProgrammazioneAl>Programmazione AL</DescLinguaggioProgrammazioneAl>
						<DescTipologiaLog>LoLogLog</DescTipologiaLog>
						<DescModalitaAccesso>Modalita accesso</DescModalitaAccesso>
						<DescSocietaVendor>Societa Vendor</DescSocietaVendor>
						<DescSocietaAm>AM Societa</DescSocietaAm>
						<ListComponente>
							<Componente>
								<Id>0</Id>
								<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
								<DtUpdate xsi:nil='true' />
								<IdComponente>1</IdComponente>
								<DescComponente>Componente Uno</DescComponente>
								<IsUsed>false</IsUsed>
								<ListAaaComponente>
									<AAAComponente>
										<Id>0</Id>
										<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
										<DtUpdate>2020-02-21T12:48:22.7601621+01:00</DtUpdate>
										<IdAAAComponente>1</IdAAAComponente>
										<IdAreaApplicativa>10</IdAreaApplicativa>
										<IdApplicazione>6</IdApplicazione>
										<IdComponente>1</IdComponente>
										<DescAAAComponente>ComponenteAAA Uno</DescAAAComponente>
										<IsUsed>false</IsUsed>
									</AAAComponente>
									<AAAComponente>
										<Id>0</Id>
										<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
										<DtUpdate xsi:nil='true' />
										<IdAAAComponente>2</IdAAAComponente>
										<IdAreaApplicativa>10</IdAreaApplicativa>
										<IdApplicazione>6</IdApplicazione>
										<IdComponente>1</IdComponente>
										<DescAAAComponente>ComponenteAAA Due</DescAAAComponente>
										<IsUsed>false</IsUsed>
									</AAAComponente>
									<AAAComponente>
										<Id>0</Id>
										<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
										<DtUpdate xsi:nil='true' />
										<IdAAAComponente>3</IdAAAComponente>
										<IdAreaApplicativa>10</IdAreaApplicativa>
										<IdApplicazione>6</IdApplicazione>
										<IdComponente>1</IdComponente>
										<DescAAAComponente>ComponenteAAA Due</DescAAAComponente>
										<IsUsed>false</IsUsed>
									</AAAComponente>
								</ListAaaComponente>
							</Componente>
							<Componente>
								<Id>0</Id>
								<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
								<DtUpdate xsi:nil='true' />
								<IdComponente>2</IdComponente>
								<DescComponente>Componente Due</DescComponente>
								<IsUsed>false</IsUsed>
								<ListAaaComponente>
									<AAAComponente>
										<Id>0</Id>
										<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
										<DtUpdate>2020-02-21T12:48:22.7601621+01:00</DtUpdate>
										<IdAAAComponente>4</IdAAAComponente>
										<IdAreaApplicativa>10</IdAreaApplicativa>
										<IdApplicazione>6</IdApplicazione>
										<IdComponente>2</IdComponente>
										<DescAAAComponente>ComponenteAAA Uno</DescAAAComponente>
										<IsUsed>false</IsUsed>
									</AAAComponente>
									<AAAComponente>
										<Id>0</Id>
										<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
										<DtUpdate xsi:nil='true' />
										<IdAAAComponente>5</IdAAAComponente>
										<IdAreaApplicativa>10</IdAreaApplicativa>
										<IdApplicazione>6</IdApplicazione>
										<IdComponente>2</IdComponente>
										<DescAAAComponente>ComponenteAAA Due</DescAAAComponente>
										<IsUsed>false</IsUsed>
									</AAAComponente>
									<AAAComponente>
										<Id>0</Id>
										<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
										<DtUpdate xsi:nil='true' />
										<IdAAAComponente>6</IdAAAComponente>
										<IdAreaApplicativa>10</IdAreaApplicativa>
										<IdApplicazione>6</IdApplicazione>
										<IdComponente>2</IdComponente>
										<DescAAAComponente>ComponenteAAA Due</DescAAAComponente>
										<IsUsed>false</IsUsed>
									</AAAComponente>
								</ListAaaComponente>
							</Componente>
						</ListComponente>
				</Applicazione>"
					,
				@"<Applicazione xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd='http://www.w3.org/2001/XMLSchema'>
						<Id>0</Id>
						<DtInsert>2020-02-21T12:48:22.7541586+01:00</DtInsert>
						<DtUpdate>2020-02-21T12:48:22.7601621+01:00</DtUpdate>
						<IdApplicazione>6</IdApplicazione>
						<IdTipologiaApplicazione>10</IdTipologiaApplicazione>
						<IdAreaApplicativa>10</IdAreaApplicativa>
						<DescApplicazione>Test File Excel</DescApplicazione>
						<IdReferente>3</IdReferente>
						<IdTipologiaReferente>7</IdTipologiaReferente>
						<IdPerimetroLivello1>10</IdPerimetroLivello1>
						<IdPerimetroLivello2>10</IdPerimetroLivello2>
						<IdPerimetroLivello3>10</IdPerimetroLivello3>
						<DescrizioneEstesa>Questa applicazione serve per tante cose</DescrizioneEstesa>
						<IdNumeroUtenti>50</IdNumeroUtenti>
						<AnnoImplementazione>2040</AnnoImplementazione>
						<AnnoDismissione>2020</AnnoDismissione>
						<IdStatoApplicazione>30</IdStatoApplicazione>
						<FlgServizioEsternalizzato>true</FlgServizioEsternalizzato>
						<IdSocietaVendor>20</IdSocietaVendor>
						<IdSocietaAM>20</IdSocietaAM>
						<FlgQRadarLogSource>false</FlgQRadarLogSource>
						<IdTipologiaLog>10</IdTipologiaLog>
						<IdModalitaAccesso>50</IdModalitaAccesso>
						<IdLinguaggioProgrUI>30</IdLinguaggioProgrUI>
						<IdLinguaggioProgrAL>70</IdLinguaggioProgrAL>
						<IdDataLayer>20</IdDataLayer>
						<Interfacce>MMMMMGGGGGOOOOO</Interfacce>
						<AltreInfo>ALTRE INFO</AltreInfo>
						<FlgRilevanzaBIA>true</FlgRilevanzaBIA>
						<FlgRilevanzaRISK>false</FlgRilevanzaRISK>
						<FlgRilevanzaSicurezza>true</FlgRilevanzaSicurezza>
						<DescAreaApplicativa>Harpo</DescAreaApplicativa>
						<DescTipologiaApplicazione>PPPP</DescTipologiaApplicazione>
						<DescPerimetroLivello1>1 - Accesso</DescPerimetroLivello1>
						<DescPerimetroLivello2>1.1 - Interno</DescPerimetroLivello2>
						<DescPerimetroLivello3>1.1.1 - Intranet</DescPerimetroLivello3>
						<DescNumeroUtenti>51-100</DescNumeroUtenti>
						<DescStatoApplicazione>In progettazione</DescStatoApplicazione>
						<DescDataLayer>DataLayer</DescDataLayer>
						<DescLinguaggioProgrammazioneUi>UI Programming</DescLinguaggioProgrammazioneUi>
						<DescLinguaggioProgrammazioneAl>Programmazione AL</DescLinguaggioProgrammazioneAl>
						<DescTipologiaLog>LoLogLog</DescTipologiaLog>
						<DescModalitaAccesso>Modalita accesso</DescModalitaAccesso>
						<DescSocietaVendor>Societa Vendor</DescSocietaVendor>
						<DescSocietaAm>AM Societa</DescSocietaAm>
						<ListComponente>
							<Componente>
								<Id>0</Id>
								<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
								<DtUpdate xsi:nil='true' />
								<IdComponente>1</IdComponente>
								<DescComponente>Componente Uno</DescComponente>
								<IsUsed>false</IsUsed>
								<ListAaaComponente>
									<AAAComponente>
										<Id>0</Id>
										<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
										<DtUpdate>2020-02-21T12:48:22.7601621+01:00</DtUpdate>
										<IdAAAComponente>1</IdAAAComponente>
										<IdAreaApplicativa>10</IdAreaApplicativa>
										<IdApplicazione>6</IdApplicazione>
										<IdComponente>1</IdComponente>
										<DescAAAComponente>ComponenteAAA Uno</DescAAAComponente>
										<IsUsed>false</IsUsed>
									</AAAComponente>
									<AAAComponente>
										<Id>0</Id>
										<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
										<DtUpdate xsi:nil='true' />
										<IdAAAComponente>2</IdAAAComponente>
										<IdAreaApplicativa>10</IdAreaApplicativa>
										<IdApplicazione>6</IdApplicazione>
										<IdComponente>1</IdComponente>
										<DescAAAComponente>ComponenteAAA Due</DescAAAComponente>
										<IsUsed>false</IsUsed>
									</AAAComponente>
									<AAAComponente>
										<Id>0</Id>
										<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
										<DtUpdate xsi:nil='true' />
										<IdAAAComponente>3</IdAAAComponente>
										<IdAreaApplicativa>10</IdAreaApplicativa>
										<IdApplicazione>6</IdApplicazione>
										<IdComponente>1</IdComponente>
										<DescAAAComponente>ComponenteAAA Due</DescAAAComponente>
										<IsUsed>false</IsUsed>
									</AAAComponente>
								</ListAaaComponente>
							</Componente>
							<Componente>
								<Id>0</Id>
								<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
								<DtUpdate xsi:nil='true' />
								<IdComponente>2</IdComponente>
								<DescComponente>Componente Due</DescComponente>
								<IsUsed>false</IsUsed>
								<ListAaaComponente>
									<AAAComponente>
										<Id>0</Id>
										<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
										<DtUpdate>2020-02-21T12:48:22.7601621+01:00</DtUpdate>
										<IdAAAComponente>4</IdAAAComponente>
										<IdAreaApplicativa>10</IdAreaApplicativa>
										<IdApplicazione>6</IdApplicazione>
										<IdComponente>2</IdComponente>
										<DescAAAComponente>ComponenteAAA Uno</DescAAAComponente>
										<IsUsed>false</IsUsed>
									</AAAComponente>
									<AAAComponente>
										<Id>0</Id>
										<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
										<DtUpdate xsi:nil='true' />
										<IdAAAComponente>5</IdAAAComponente>
										<IdAreaApplicativa>10</IdAreaApplicativa>
										<IdApplicazione>6</IdApplicazione>
										<IdComponente>2</IdComponente>
										<DescAAAComponente>ComponenteAAA Due</DescAAAComponente>
										<IsUsed>false</IsUsed>
									</AAAComponente>
									<AAAComponente>
										<Id>0</Id>
										<DtInsert>2020-02-21T12:48:22.7601621+01:00</DtInsert>
										<DtUpdate xsi:nil='true' />
										<IdAAAComponente>6</IdAAAComponente>
										<IdAreaApplicativa>10</IdAreaApplicativa>
										<IdApplicazione>6</IdApplicazione>
										<IdComponente>2</IdComponente>
										<DescAAAComponente>ComponenteAAA Due</DescAAAComponente>
										<IsUsed>false</IsUsed>
									</AAAComponente>
								</ListAaaComponente>
							</Componente>
						</ListComponente>
					</Applicazione>"
			};
		}
    }
}