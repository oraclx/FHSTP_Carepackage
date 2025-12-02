# Netzwerktechnik:


## 1.	IPv4-Unicast-Bereiche
### Frage (W/F): IPv4-Unicast-Adressen beginnen im ersten Oktett immer zwischen 1–223.
- [ ] Wahr
- [ ] Falsch

<details> 
    <summary>Antwort</summary>
    Antwort: Falsch. <br> Korrekt: 1–223, aber 127.x.x.x ist Loopback; 0.x.x.x reserviert; 224–239 Multicast; 240–255 reserviert.
</details>

## 2.	IP vs. MAC
### Frage (W/F): „IP-Adressen sind physische Adressen, MAC-Adressen logische.“
- [ ] Wahr
- [ ] Falsch

<details> 
    <summary>Antwort</summary>
    Antwort: Falsch. IP = logisch (Layer 3), MAC = physisch/Link-Layer (Layer 2).
</details>

## 3.	Eigenschaften von IPv4
### Frage (MC, Mehrfachauswahl): Welche Aussagen treffen zu?
- [ ] a) IPv4-Adressen bestehen aus 32 Bits.
- [ ] b) IPv4-Adressen werden immer in Dezimalnotation angegeben.
- [ ] c) IPv4-Adressen werden immer in Hexadezimalnotation angegeben.
- [ ] d) IPv4-Adressen bestehen aus 128 Bits.

<details> 
    <summary>Antwort</summary>
    Antwort: a.
</details>

## 4.	Loopback-Adressen
### Frage (MC, Mehrfachauswahl): Welche sind gültige Loopback-Adressen?
- [ ] a) `0.0.0.0`
- [ ] b) `::1`
- [ ] c) `192.168.0.1`
- [ ] d) `::`
- [ ] e) `127.0.0.1`

<details> 
    <summary>Antwort</summary>
    Antwort: b, e.
</details>

## 5.	Klasse-C-Hostanzahl
### Frage (W/F): „In einem Klasse-C-Netz können maximal 154 Hostadressen bereitgestellt werden.“
- [ ] Wahr
- [ ] Falsch

<details> 
    <summary>Antwort</summary>
    Antwort: Falsch. Maximal 254 Hosts (256 minus Netz- und Broadcastadresse).
</details>

## 6.	Well-Known Ports zuordnen
### Frage (Zuordnung): Ordnen Sie die Serverportnummern zu.

| Header 1 | Header 2 |
|----------|----------|
| FTP:     | <select><option value="option1" selected></option><option value="option1">21</option><option value="option2">53</option><option value="option3">80</option><option value="option4">443</option><option value="option5">25</option><option value="option6">110</option></select> |
| DNS:     | <select><option value="option1" selected><option value="option1">21</option><option value="option2">53</option><option value="option3">80</option><option value="option4">443</option><option value="option5">25</option><option value="option6">110</option></select> |
| HTTP:     | <select><option value="option1" selected><option value="option1">21</option><option value="option2">53</option><option value="option3">80</option><option value="option4">443</option><option value="option5">25</option><option value="option6">110</option></select> |
| HTTPS:     | <select><option value="option1" selected><option value="option1">21</option><option value="option2">53</option><option value="option3">80</option><option value="option4">443</option><option value="option5">25</option><option value="option6">110</option></select> |
| SMTP:     | <select><option value="option1" selected><option value="option1">21</option><option value="option2">53</option><option value="option3">80</option><option value="option4">443</option><option value="option5">25</option><option value="option6">110</option></select> |
| POP3:     | <select><option value="option1" selected><option value="option1">21</option><option value="option2">53</option><option value="option3">80</option><option value="option4">443</option><option value="option5">25</option><option value="option6">110</option></select> |


<details> 
    <summary>Antwort</summary>
    Antwort:

- FTP 21, 
- DNS 53, 
- HTTP 80, 
- HTTPS 443,
- SMTP 25,
- POP3 110.
</details>

## 7.	Private IPv4-Adressen
### Frage (MC, Mehrfachauswahl): Welche gelten als private Adressen?
- [ ] a) `198.1.1.1`
- [ ] b) `10.255.255.254`
- [ ] c) `172.16.0.1`
- [ ] d) `172.15.1.1`
- [ ] e) `172.32.0.1`

<details> 
    <summary>Antwort</summary>
    Antwort: b, c.
</details>

## 8.	Klasse der Adresse 190.6.255.254
### Frage (W/F): „Die IP-Adresse 190.6.255.254 gehört in Netzwerkklasse B.“
- [ ] Wahr
- [ ] Falsch

<details> 
    <summary>Antwort</summary>
    Antwort: Wahr. (128–191 = Klasse B)
</details>

## 9.	Nicht-private nach RFC1918
### Frage (MC, Mehrfachauswahl): Welche sind keine privaten Adressen?
- [ ] a) `172.31.1.1`
- [ ] b) `10.255.1.1`
- [ ] c) `172.33.1.1`
- [ ] d) `191.168.1.1`
- [ ] e) `10.1.255.1`

<details> 
    <summary>Antwort</summary>
    Antwort: c, d.
</details>

## 10.	Broadcast-MAC
### Frage (W/F): „ff:ff:ff:ff:ff:ff ist eine korrekte MAC-Adresse.“
- [ ] Wahr
- [ ] Falsch

<details> 
    <summary>Antwort</summary>
    Antwort: Wahr. (Layer-2-Broadcast)
</details>

## 11.	Router-Entscheidung (allgemein)
### Frage (Kurzantwort): Welche Adresse nutzt ein Router typischerweise für seine Weiterleitungsentscheidung?

<input type="text" value="Text hier" style="width: 100%;">

</br>
<details> 
    <summary>Antwort</summary>
    Antwort: Ziel-IP-Adresse (Destination IP).
</details>

## 12.	Router-Entscheidung (MC-Variante)
### Frage (MC): a) Empfänger-MAC- und Empfänger-IP-Adresse

<details> 
    <summary>Antwort</summary>
    Antwort: a = falsch. Router betrachten die Ziel-IP, nicht die MAC-Adresse (Layer-3-Routing).
</details>

## 13.	Klasse der Adresse 120.6.255.254
### Frage (W/F): … gehört in Klasse B.
- [ ] Wahr
- [ ] Falsch

<details> 
    <summary>Antwort</summary>
    Antwort: Falsch. Klasse A (1–126).
</details>

## 14.	Standard-Gateway notwendig?
### Frage (W/F): Ein Standard-Gateway ist nicht notwendig, um andere logische Netze zu erreichen.
- [ ] Wahr
- [ ] Falsch

<details> 
    <summary>Antwort</summary>
    Antwort: Falsch. (Alternativ ginge eine passende statische Route; ohne irgendeine Route geht es nicht.)
</details>

## 15.	Skalierbare Topologie
### Frage (MC, Einfachauswahl): 
- [ ] a) Ring 
- [ ] b) Maschen 
- [ ] c) Stern 
- [ ] d) Bus

<details> 
    <summary>Antwort</summary>
    Antwort: c) Stern. (Einfach erweiterbar; Voll-Mesh skaliert schlecht wegen vieler Verbindungen.)
</details>

## 16.	LAN-Technologien
### Frage (MC, Mehrfachauswahl): 
- [ ] a) ADSL 
- [ ] b) LTE 
- [ ] c) WLAN 
- [ ] d) Ethernet

<details> 
    <summary>Antwort</summary>
    Antwort: c, d.
</details>

## 17.	Aussagen über Router
### Frage (MC, Mehrfachauswahl):
- [ ] a) Router sind OSI-Layer-4-Geräte.
- [ ] b) Weiterleitung per IP-basierter Routingtabelle.
- [ ] c) Wege dynamisch (Routingprotokolle) oder statisch erlernbar.
- [ ] d) Broadcasts werden nur mit IP-Helper/Relay weitergeleitet.

<details> 
    <summary>Antwort</summary>
    Antwort: b, c, d. (a ist falsch; Router arbeiten primär auf Layer 3.)
</details>

## 18.	Gültige Hostadressen (klassenbasiert)
### Frage (MC, Mehrfachauswahl):
- [ ] a) `11.1.222.0`
- [ ] b) `192.167.0.1`
- [ ] c) `198.121.255.254`
- [ ] d) `22.255.255.255`
- [ ] e) `127.0.0.1`
- [ ] f) `192.168.0.255`

<details> 
    <summary>Antwort</summary>
    Antwort: b, c. (a Netz, d Broadcast, e Loopback, f Broadcast)
</details>

## 19.	Maximale TP-Segmentlänge (IEEE)
### Frage (MC): 
- [ ] a) 500 m
- [ ] b) 2000 m
- [ ] c) 100 m
- [ ] d) 1000 m

<details> 
    <summary>Antwort</summary>
    Antwort: c) 100 m (z. B. 10/100/1000BASE-T).
</details>

## 20.	IPv6-Kurzschreibweise
### Frage (MC): Kürzeste gültige Abkürzung für FE80:0000:0000:0100:0000:0000:0000:0123
- [ ] a) `FE80::100:0:0:0:123:4567`
- [ ] b) `FE80:0:0:100::123`
- [ ] c) `FE80::100::123`
- [ ] d) `FE8::1::123`

<details> 
    <summary>Antwort</summary>
    Antwort: b.
</details>

## 21.	Switch & Netze
### Frage (W/F): „Switches leiten aufgrund ihrer MAC-Tabellen grundsätzlich zwischen verschiedenen logischen Netzen zu.“
- [ ] Wahr
- [ ] Falsch

<details> 
    <summary>Antwort</summary>
    Antwort: Falsch. (Layer-2; Routing macht Layer-3.)
</details>

## 22.	Physikalische Bus-Topologie heute?
### Frage (W/F): „Heutige Ethernet-Netze sind üblicherweise physikalische Busse.“
- [ ] Wahr
- [ ] Falsch

<details> 
    <summary>Antwort</summary>
    Antwort: Falsch. (Heute i. d. R. Stern um Switches.)
</details>

## 23.	Klasse-A-Beginn
### Frage (W/F): „Klasse-A-Adressen beginnen im ersten Oktett zwischen 1–127.“
- [ ] Wahr
- [ ] Falsch

<details> 
    <summary>Antwort</summary>
    Antwort: Falsch. Übliche (nutzbare) Klasse-A-Netze beginnen 1–126; 127/8 ist Loopback reserviert.
</details>