USIBA
=====

INTERFAZ  USB  PARA APLICACIONES BIOMEDICAS
Jonathan Olier djom202@gmail.com

Universidad Simón Bolívar
Facultad de Ingeniería de Sistemas

 
Resumen—    En este artículo se describe el desarrollo de un sistema de cómputo para adquisición de señales biomédica y transmisión de la información a un equipo de cómputo por medio de los  protocolos USB (universal serial bus) y HID (Human Interface Device). Este sistema se desarrollo para que fuese sencillo de manipular y comprender para lograr su posterior manipulación, por lo que se baso en la programación orientada a objeto implementada en el lenguaje de programación visual basic.Net, por el cual se logro realizar la comunicación de forma ágil y eficaz a una tarjeta electrónica que contiene un micro-controlador PIC18F4550, que adquiere las señales análogas como la ECG (Electro Cardiograma), EEG (Electro Encefalograma) ó EMG de un dispositivo biomédico y posteriormente se puedan ser almacenadas y visualizadas por el aplicativo. Esta estructuración permite avanzar en los procesos de agilización de la obtención de los resultados de un paciente de forma ágil, eficaz y contundente.
Palabras claves: Señales, biomédicas, adquisición, micro-controlador, USB, PIC18F.

Abstract— This article describes the development of a computer system for biomedical signal acquisition and transmission of information to a computer equipment through the USB protocol (universal serial bus) and HID (Human Interface Device).
This system was developed to be simple to manipulate and understand in order to achieve further handling, so it was based on object oriented programming implemented in basic.Net visual programming language, which was achieved by performing communication in a quickly and efficiently to an electronic card that contains a PIC18F4550 microcontroller, which acquires analog signals such as ECG (Electro Cardio), EEG (EEG) or EMG of a biomedical device and then can be stored and displayed by the application .
This structure allows progress in streamlining the process of obtaining the results of a patient in a flexible, effective and forceful.
Keywords: Signals, biomedical, acquisition, micro-controller, USB, PIC18F.


INTRODUCCION
=====

En el pasado el médico diagnosticaba las enfermedades mediante el método sintomático, esto se refiere a que basaba en una serie de pregunta hacia el  paciente, el medico infería la enfermedad y daba tratamiento para cada uno de los síntomas, desafortunadamente según cifras de la OMS contaba entre un  55% a un 60% de certeza en el diagnostico mediante el uso de tecnología, el medico puede hacer rigurosos estudios científico los cuales arrojan resultados reales e indican o muestran la existencias de una enfermedad determinada con el empleo de tecnología para diagnóstico. En la actualidad se han desarrollado millones de software muy eficientes en diferentes áreas de interés sin embargo la lucha que se mantiene no es en la eficiencia sino en la cantidad de recursos de hardware que se necesitan para la implementación o el costos de los mismo. La implementación del software actualmente se disputa en un software que utilice los recursos de hardware más baratos y sencillos pero que a su vez pueda competir con cualquier otro que realice lo mismo y tenga los mejores recursos de hardware. [1]
El proporcionar a la sociedad la implementación ó desarrollo de nuevas tecnologías informáticas, para mejorar la comunicación, comprensión y manejo de la información médica hacia los pacientes, necesitara una óptima gestión administrativa de información que actualmente no es posible a pesar de los arduos avances en la tecnología, además que el desarrollo de nuevas tecnologías aplicadas en el ámbito de la salud requiere no sólo de una gran inversión de recursos económicos sino de su desarrollo y de la comunicación para los procesos clínicos y de investigación que van de la mano con una serie de protocolos y reglamentos que no siempre son fáciles de elaborar a pesar que la Biomédica facilita el manejo de una gran cantidad de datos y la ejecución de análisis computacional muy sofisticado, en la actualidad aun no se ha podido implementar de una forma sencilla. [7]
Por tales razones se pensó en la elaboración de un sistema de cómputo que permitiera la interconexión por medio de un protocolo de comunicación que fuese universal de un dispositivo biomédico a un centro de cómputo que a su vez tuviese un bajo costo de elaboración y que tuviera una licencia libre de costos por uso y/o implementación, por ello se desarrollo USIBA (USb Interface for  Biomedical Application), como ayuda a la fácil recolección de datos en la Biomedicina y como base para futuros proyectos que requieran este tipo de especificaciones.
Este aplicativo capta la señal procedente de la placa que esta a su vez es obtenida del equipo de biomedicina y está basado en la programación orientada a objeto. Este se basa en un sistema de comunicación entre una serie de dispositivos electrónicos-informáticos que transmite al micro-controlador PIC18F4550, que permite gestionar mediante software la comunicación a través de interface USB 2.0.
Con USIBA se realizo la comunicación entre los equipos de biomedicina y un centro de cómputo mediante la conexión USB, por la cual se podrá adquirir señales análogas mediante un dispositivo Biomédico como la ECG y transferir este tipo de datos a al equipo de cómputo para administrar esta información referente a los usuarios en el campo de la biomedicina.


DESCRIPCIÓN GENERAL DE LA TECNOLOGÍA USB

Las siglas USB corresponden a Universal Seria Bus, como su nombre lo indica, se trata de un sistema de comunicación entre dispositivos electrónicos-informáticos que sólo transmite una unidad de información a la vez. El bus USB puede trabajar en dos modos, a baja velocidad (1,5 Mbps, para dispositivos como teclados, ratones, que no utilizaran grandes cantidades de información) y a alta velocidad (12 Mbps, para dispositivos como unidades de CDROM, altavoces y módems, etcétera). En cuanto a la comodidad, el bus USB se compacta en un cable de cuatro hilos, dos para datos (data+ y data-), dos para alimentación (+5v y tierra o Gnd). Esto supone un gran ahorro, tanto de espacio como de material. De acuerdo a estos parámetros, una de las principales ventajas que se obtiene del USB es precisamente su diseño. [7]


JUSTIFICACION
=====

El USB organiza el bus en una estructura de árbol descendente, con múltiples dispositivos conectados a un mismo bus, en la que unos elementos especiales, llamados hubs (Dispositivo que contiene uno o mas conectores o conexiones internas hacia otros dispositivos usb, el cual habilita la comunicación entre el host y  con diversos  dispositivos. Cada conector representa un puerto USB), enrutan las señales en su camino desde un dispositivo al host o viceversa. Primero está el controlador del bus, éste es la interfaz entre el bus USB y el bus del ordenador, de él cuelgan los dispositivos USB. A un hubs se puede conectar uno o más dispositivos, que a su vez pueden ser 
otros hubs, así tenemos varios dispositivos conectados a un sólo controlador; como máximo alrededor de 126. [8]


DESCRIPCIÓN DEL SISTEMA
=====
 
Fig. 3. Estructura de adquisición del sistema, (Esquema de interconexión USB). [9]

Este sistema consta de tres elementos, el aplicativo como tal, la tarjeta electrónica y las librerías que permiten la interconexión con el protocolo USB, HID y la base de datos. El Aplicativo fue desarrollado en visual basic.net 2010 junto el framework de Microsoft en su versión 4, esta es la interfaz en la cual se mostrara gráficamente el conjunto de datos recibidos por la tarjeta electrónica que fue elaborada y construida cuidadosamente circuito por circuito hasta finalizar en su totalidad la tarjeta electrónica y la tercera parte son las .dll, mcHID.dll y MySql.Data.dll.
Con el micro controlador PIC18F4550 por medio del protocolo USB (Universal Serial Bus) junto con el protocolo de comunicación HID (Human Interface Device) que comúnmente se refiere a la especificación USB-HID, además la realización de la conversión en las señales enviadas por el dispositivo biomédico a través del micro controlador a un tipo de datos leíbles y manejable para cualquier usuario en el  equipo de cómputo para su posterior uso y análisis en el campo de la biomédica. Detallaremos cada uno de los módulos construidos además de realizar una breve descripción de como se usaron las librerías como mcHID.dll y MySql.Data.dll. [14]
Para las gráficas estadísticas e información relacionada con los datos recibidos se utilizara el componente o control suministrado por el ambiente de desarrollo de Visual Studio 2010 llamado Chart que fue añadido en el Framework 4.
En la comunicación con el protocolo HID, existe 2 entidades: el host y el dispositivo. El dispositivo es la entidad que interactúa directamente con el humano, como lo hace un teclado o un ratón y en nuestro caso es la placa base con el micro-controlador PIC18F4550. El host se comunica con el dispositivo y recibe datos de entrada del dispositivo en las acciones ejecutadas por el humano, para nosotros el host es USIBA que recibe los datos de la placa base que a su vez recibe las señales de un dispositivo biomédico. Los datos de salida van del host al dispositivo y luego al humano. El dispositivo como todo posee una serie de identificaciones únicas que son ID del vendedor, ID del producto, al momento de la conexión solo se realizara con aquel dispositivo que contenga estas identificaciones. [4]
El A/D (análoga/digital) es un dispositivo electrónico capaz de convertir una entrada analógica de voltaje en un valor binario. En la etapa donde se adquieren los datos, el micro-controlador esta compuesto  por un conversor A/D de 10 bits y un componente software, que realiza la rutina encargada  de dirigir el funcionamiento del conversor A/D. [13]
Luego el dispositivo Biomédico conectado a la tarjeta electrónica procede a enviar los datos de forma análoga y son recibidos por los puertos AN0 y AN1, a medida que son recibidos por la tarjeta electrónica que realiza una conversión A/D, y los renvía a la interfaz USB por medio por modulo USB del micro-controlador PIC18F4550 usando los registros USB Buffer.
Una vez que se han obtenido las muestras deseadas por la aplicación en visual Basic.Net de forma digital por la tarjeta electrónica, se llevar a cabo la grafica de los datos por medio de un objeto llamado chart (objeto estándar dentro de visual Basic.Net), además también los datos son registrados en la base de datos para su posterior análisis. [15]


DESARROLLO DEL SOFTWARE
=====

USIBA está basado en la programación orientada a objeto  implementada en el lenguaje de programación Visual Basic.Net, esta aplicación consta de tres partes fundamentales la primera son las librerías DLL (mcHID.dll, MySQl.data.dll y accesoDatos.dll) necesarias para conectar el aplicativo con la placa e interpretar el protocolo USB y HID, además de la conexión a la base de datos y el manejo o manipulación de los datos en la conexión USB, respectivamente. [2]
 
Fig. 4. Pantalla de bienvenida de USIBA.

La segunda parte es la conexión con la base de datos que nos permitirá guardar los datos que procese del dispositivo biomédico y formar el historial de estas mismas, y la tercera parte es la interfaz compuesta por dos visores de señales que van a permitir que el usuario compruebe el comportamiento de las señales.
En el software una vez llegada la señal al computador, este la capta utilizando las DLL (mcHID.dll y accesodatos.dll) encargadas de proveer los mecanismos necesarios para la utilización del protocolo USB y HID, una vez siendo interpretadas se procede a almacenarlos en la base de datos y posteriormente a graficarlos en los visores, los cuales les servirán al usuario para dar un mejor diagnostico a la hora de usar un equipo de biomédica.
CARACTERÍSTICA DE LA INTERFAZ
 
Fig. 5. Interfaz Grafica de USIBA.

Dispositivo que adquiere de señales análogas, las grafica y la guarda. Los valores de la oscilación, están dados en tiempo ya que el cristal implementado por el micro-controlador PIC18f4550  maneja la oscilación en valor de milisegundos que es la frecuencia con que son enviados los datos por teorema de muestreo de Nyquist-Shannon, dice que la reconstrucción exacta de una señal periódica continua en banda base a partir de sus muestras, es matemáticamente posible si la señal está limitada en banda y la tasa de muestreo es superior al doble de su ancho de banda, y en nuestro caso la señal ECG tiene componentes en frecuencia de máximo 250Hz por lo que se debe muestrear mínimo a 500Hz. [17]
Menú de la aplicación
 
Fig. 6. Menú de USIBA.

Configuración de la conexión a la base de datos
 
Fig. 7. Pestaña MySQL, configuraciones de la conexión a la base de datos de USIBA.
Configuración a la oscilación de la grafica
 
Fig. 8. Pestaña de Oscilación de USIBA.
DESCRIPCIÓN DE LOS MÓDULOS O CIRCUITOS ELÉCTRICOS
Para la construcción de la placa elaboraremos una serie de módulos o circuitos eléctricos uno a uno que iremos interconectándolo.

Micro-controlador  PIC18F4550
Este micro-controlador PIC18F4550, es ideal para trabajar a baja potencia (nanoWatt) y aplicaciones de conectividad que se benefician de la disponibilidad de un puerto USB. Además que contiene grandes cantidades de memoria RAM para el almacenamiento en búfer y la memoria Flash del micro-controlador PIC ha mejorado, lo que lo hace perfecto para los controles integrados y que requieran de aplicaciones periódicas ó de seguimiento con una conexión a un ordenador personal a través del Protocolo USB para la carga de datos, actualizaciones de descarga y/o firmware. El micro-controlador PIC18F4550 está fabricado en tecnología CMOS que hace que el consumo de potencia sea bajo y estático. [18]
 
Fig. 9. Diagrama de pines del Micro-controlador PIC18F4550. [18]

El encapsulado es más común para estos micro controlador es el DIP (Dual In line Pin) de 18 pines, este diseño utiliza un reloj de 4 MHz (cristal de cuarzo). Existen otros tipos de encapsulado, por ejemplo, el encapsulado tipo surfacemount (montaje superficial) es mucho mas pequeño.
El circuito o modulo de alimentación.
 
Fig. 10. Circuito de alimentación de la tarjeta electrónica

El cual tiene una entrada de 9v que es ingresa a un regulador de voltaje 7805,  para mantener la diferencia de potencial constante a 5v y pueda continuar el circuito sin causar daños a los demás componentes, además que contiene un LED que nos indica si se esta recibiendo energía o no.
LED (Diodo emisor de luz)  es  un dispositivo que  tiene en su interior material semiconductor que al aplicarle una pequeña corriente produce luz, esta luz no produce calor y es de un determinado color, además no produce aumento de la temperatura. [9]
El circuito o modulo pulsador.
 
Fig. 7. Circuito pulsador

Fig. 8. Circuito reset
Este circuito permite generar unas señales eléctricas correspondientes a 1 y 0 lógicos para ser ingresadas en las entradas del micro-controlador para que posteriormente se realicen cambios y/o visualizaciones por medio del puerto B del mismo.
Circuito Reset del micro-controlador

El micro-controlador PIC18F4550  recibe constantemente energía por el pin MCRL para estar en funcionamiento, en el momento que la energía es enviada a tierra por la interrupción de botón, se envía una señal al micro-controlador para entrar en estado de reset de forma manual, ya que se realiza cada vez que se requiera.
 
Fig. 9. Circuito resonante

Circuito resonante

Este circuito esta constituido por un cristal y dos condensadores de 27 µF que van a tierra. El PIC trabaja a 4MHz y lo que se realiza es generar 48MHz para el funcionamiento del modulo USB.


Modulo USB
=====
 
Fig. 11. Modulo USB.  Tiene un capacitor va a tierra por un puerto VUSB del micro-controlador.

Este circuito lleva la información al PC a través de un buffer en forma digital, tiene un LED que indica si esta llegando la información al PC, una resistencia y va a tierra.

El Oscilador Externo
En el momento de programar la aplicación en el micro controlador se debe especificar que tipo de oscilador se desea usar. Esto se hace a través de unos fusibles llamados "fusibles de configuración" o fuses. El micro-controlador PIC18f44550 puede utilizar cuatro tipos de reloj diferentes, como lo es el RC (Oscilador con resistencia y condensador), el XT, el HS (Cristal de alta velocidad) y el LP (Cristal para baja frecuencia y bajo consumo de potencia). En este caso se utilizo el XT, ya que es una configuración que se utiliza para implementar un cristal externo.
 
El cristal utilizado es de 4MHz, que garantiza mayor precisión y el buen funcionamiento del micro-controlador, ya que para esto requiere 4 ciclos de reloj (4MHz), lo que corresponde a un micro-segundo que es el tiempo en que se tarda en ejecutar cada instrucción almacenada en el micro-controlador, además el micro-controlador internamente divide por 4 esta señal para luego pasar a un PLL (del inglés phase-locked loop ó  bucles de enganche de fase) que la multiplica para generar 48Mhz para el modulo usb.

Modulo de visualización del puerto B
 
Fig. 13. Modulo de visualización del puerto B

Aquí podemos mirar si se esta transmitiendo información o no, encaso de que no se esté recibiendo información los LED no enciende o la luz no se mantiene estática.
Circuito de adquisición de datos
 
Fig. 14. Circuito de recepción de la señal análoga por parte del dispositivo Biomédico.

Se conecta un electrocardiograma para la obtención de la señal análoga del paciente. 

Circuito completo

 
Esquema de sistema USIBA
=====
 
PROGRAMADOR
 
Fig. 15. Quemador PICSTART Plus desarrollado por Microchip.

Los micro-controladores de Microchip (PIC) son programados  a través  un protocolo tipo serie. Se utilizan dos tensiones de alimentación para realizar la programación: una de 4.5v a 5.5v (VDD) y otra comprendida entre 12v y 14v (VPP), que es la que indica al PIC que va a ser programado, para que el cambie la función que realizan los pines I/O implicados en la programación. Los pines implicados en la programación cambian  de un micro controlador a otro, pero en general, los de un mismo numero de pines (8, 18, etc.) tienen las mismas patitas asignadas a la programación, lo que nos conlleva construir programadores que se utilicen  para mas de un PIC. [19]
CONCLUSION

El desarrollo de la aplicación esta encaminada en el área de la biomedicina y a las nuevas tecnologías que nos ayudan a mejorar y mantener organizada todo tipo de información en esta área, esta investigación ha ayudado al desarrollo de una placa y un software para equipos de biomedicina que Va a permitir mejorar el tiempo de comunicación entre dichos equipos y el computador.
También podemos concluir que hemos logrado todos los objetivos planteados anteriormente y logramos el resultado esperado gracias a la ayuda de esta investigación. 
REFERENCIAS

1. Sistemas de Acceso Inteligente a la Información, Biomédica: una revisión. Laura Plaza Morales, Jorge Carrillo de Albornoz Cuadrado,  Juan Carlos Prados Frutos url: 
www.saludcordoba.gov.co/archivos_de.../tecnologiabiomedica.pdf
http://revistas.ucm.es/enf/18877249/articulos/RICP1010120007A.PDF

2. Vidal Silva, CristianAndGatica Rojas, Valeska. Design and implementation of a digital electrocardiographic system.Rev.fac.ing.univ. Antioquia. [online]. Sept. 2010, no.55 [cited 26 May 2011], p.99-107. Available from World Wide Web: <http://www.scielo.unal.edu.co/scielo.php?Script=sci_arttext&pid=S0120-62302010000500010&lng=en&nrm=iso>. ISSN 0120-6230.

3. HAVES, Ángel M, GARCIA, Ronald G, GAMBOA, Wilson et al. Construcción y validación clínica de un prototipo para el registro continuo de la presión arterial de forma no invasiva y ambulatoria. Rev. Colom. Cardiol. [Online]. Ene. /feb. 2009, vol.16, no.1 [citado 26 Mayo 2011], p.11-18. Disponible en la World Wide Web: <http://www.scielo.unal.edu.co/scielo.php?script=sci_arttext&pid=S0120-56332009000100003&lng=es&nrm=iso>. ISSN 0120-5633.

4. Sheu, Yung-Hoh; Dai, Yu-Ping; Fu, Duen- Shiang; , "Embedded USB homecare internet system," Circuits and Systems (APCCAS), 2010 IEEE Asia Pacific Conference on , vol., no., pp.442-445, 6-9 Dec. 2010 doi: 10.1109/APCCAS.2010.5775051 URL: http://ieeexplore.ieee.org/stamp/stamp.jsp?tp=&arnumber=5775051&isnumber=5774732

5. Walker, B.A.; Khandoker, A.H.; Black, J.; , "Low cost ECG monitor for developing countries," Intelligent Sensors, Sensor Networks and Information Processing (ISSNIP), 2009 5th International Conference on , vol., no., pp.195-199, 7-10 Dec. 2009
doi: 10.1109/ISSNIP.2009.5416759 URL: http://ieeexplore.ieee.org/stamp/stamp.jsp?tp=&arnumber=5416759&isnumber=5416740
6. Carboni, C.; Loi, D.; Angius, G.; , "A microcontrolled neural interface with electrode impedance measurement," Ph.D. Research in Microelectronics and Electronics (PRIME), 2010 Conference on , vol., no., pp.1-4, 18-21 July 2010
URL: http://ieeexplore.ieee.org/stamp/stamp.jsp?tp=&arnumber=5587129&isnumber=5587092

7. XinGuo; Weijie Chen; XiaoyunXu; He Li; , "The research of portable ECG monitoring system with USB host Interface," Biomedical Engineering and Informatics (BMEI), 2010 3rd International Conference on , vol.4, no., pp.1614-1618, 16-18 Oct. 2010 doi: 10.1109/BMEI.2010.5639298 URL: http://ieeexplore.ieee.org/stamp/stamp.jsp?tp=&arnumber=5639298&isnumber=5639233

8. O'Connell, Eoin; O'Connell, Sean; McEvoy, Robert P.; Marnane, William P.; , "A low-power wireless ECG processing node and remote monitoring system," Signals and Systems Conference (ISSC 2010), IET Irish , vol., no., pp.48-53, 23-24 June 2010
doi: 10.1049/cp.2010.0486 URL: 
www.tegnologia-usb.html
http://ieeexplore.ieee.org/stamp/stamp.jsp?tp=&arnumber=5638444&isnumber=5638401

9. Ho, C.S.; Chiang, T.K.; Lin, C.H.; Lin, P.Y.; Cheng, J.L.; Ho, S.H.; , "Design of Portable ECG Recorder with USB Storage," Electron Devices and Solid-State Circuits
, 2007. EDSSC 2007. IEEE Conference on, vol., no., pp.1095-1098, 20-22 Dec. 2007
doi: 10.1109/EDSSC.2007.4450319 URL: www.metrolightes.com/catalogo_leds_quees.htmEspaña 
http://ieeexplore.ieee.org/stamp/stamp.jsp?tp=&arnumber=4450319&isnumber=4450045

10. SANZ PUPO, Nitza Julia et al. La digitalización de imágenes aplicadas a la anatomía patológica: Experiencias en la provincia Holguín, Cuba.Rev Cubana InvestBioméd [online]. 2006, vol.25, n.4 [citado  2011-05-29], pp. 0-0 . Disponible en: <http://scielo.sld.cu/scielo.php?script=sci_arttext&pid=S0864-03002006000400001&lng=es&nrm=iso>. ISSN 0864-0300.

11. Aplicaciones biomédicas de la microscopia electrónica y el análisis elemental con espectrómetro de Rayos X, http://www.scielo.sa.cr/scielo.php?pid=S0253-29482002000200005&script=sci_arttext

12. O'Connell, Eoin; O'Connell, Sean; McEvoy, Robert P.; Marnane, William P.; , "A low-power wireless ECG processing node and remote monitoring system," Signals and Systems Conference (ISSC 2010), IET Irish , vol., no., pp.48-53, 23-24 June 2010
doi: 10.1049/cp.2010.0486
www.mastermagazine.info › Definición término
URL: http://ieeexplore.ieee.org/stamp/stamp.jsp?tp=&arnumber=5638444&isnumber=5638401

13. Microchip, PIC 18F2455/2550/4455/4550, Data Sheet, 2007.
URL:
http://ieeexplore.ieee.org/stamp/stamp.jsp?tp=&arnumber=5871931&isnumber=5871830
www.dspace.epn.edu.ec/bitstream/

14. Micro controlador micro-controlador 18F4550, Departamento de Ingeniería Electrónica de la    Universidad Politécnica deValencia, 2008.
URL: http://ieeexplore.ieee.org/stamp/stamp.jsp?tp=&arnumber=5871931&isnumber=5871830

15. D. W. Evertson, M. R. Holcomb, M. Eames, M. Bray, V. Y. Sidorov, J. Xu, H. Wingard, H. M. Dobrovolny, M. C. Woods, D. J. Gauthier, and J. P. Wikswo, IEEE Trans. Biomed. Eng. 55, 1241 _2008_.
http://rsi.aip.org/resource/1/rsinak/v79/i12/p126103_s1?bypassSSO=1.

16. V. Y. Sidorov, M. R. Holcomb, M. C. Woods, R. A. Gray, and J. P. Wikswo, Basic Res. Cardiol. 103, 537 _2008_.
http://rsi.aip.org/resource/1/rsinak/v79/i12/p126103_s1?bypassSSO=1.

17. Ho, C.S.; Chiang, T.K.; Lin, C.H.; Lin, P.Y.; Cheng, J.L.; Ho, S.H.; , "Design of Portable ECG Recorder with USB Storage," Electron Devices and Solid-State Circuits, 2007. EDSSC 2007. IEEE Conference on , vol., no., pp.1095-1098, 20-22 Dec. 2007
doi: 10.1109/EDSSC.2007.4450319
URL: http://ieeexplore.ieee.org/stamp/stamp.jsp?tp=&arnumber=4450319&isnumber=4450045

18. Microchip, PIC 18F2455/2550/4455/4550 Data sheet [Online]. Aviable: http://www.microchip.com/wwwproducts/Devices.aspx?dDocName=en010300

19. Microchip, PICSTART Plus, [Online]. Aviable: http://www.microchip.com/stellent/idcplg?IdcService=SS_GET_PAGE&nodeId=1406&dDocName=en010020

