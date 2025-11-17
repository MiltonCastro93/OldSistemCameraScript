# Camera Switching Prototype – Third ↔ First Person (Unity, Custom System)

Este proyecto es un **prototipo propio** donde se implementa un sistema de cámaras programado **desde cero**, sin utilizar Cinemachine ni controladores prearmados.  
El objetivo fue comprender el comportamiento interno de una cámara TPS/FPS y cómo interactúa con el personaje, el mundo y la rotación.

El sistema cuenta con **tres scripts principales**, cada uno cumpliendo un rol específico:  
- Control manual de la cámara en tercera persona.  
- Sistema de cambio entre cámaras.  
- Un sistema auxiliar para dirigir la mirada del personaje.

---

## 🎮 Características del Prototipo

### 🔄 Cambio de Cámara con un Solo Botón
- Permite alternar entre:
  - **Cámara en tercera persona (TPS)**
  - **Cámara en primera persona (FPS)**
- Programado 100% desde 0.
- No depende de Cinemachine.
- Las cámaras se activan/desactivan limpiamente.

---

## 📷 Scripts Incluidos

### 1️⃣ **C3Camera.cs — Control completo de cámara en tercera persona**
Este script controla el movimiento y rotación de la cámara TPS de forma manual:
- Rotación con los ejes Horizontal y Vertical.
- Limitación del ángulo máximo permitido para evitar giros irreales.
- Mantiene el eje Z estable para evitar inclinaciones no deseadas.
- Ajusta la cámara para que siempre mire hacia el personaje.
- Se ejecuta en **LateUpdate** para evitar jitter visual.

Este componente ofrece un control fino, ideal para un TPS personalizado.

---

### 2️⃣ **CCambio.cs — Sistema de cambio entre cámaras**
Controla el **switch** entre primera y tercera persona usando la tecla **C**:
- Enciende y apaga cada cámara correctamente.
- Restablece la rotación inicial para evitar errores acumulados.
- Permite ampliar el sistema a más cámaras fácilmente.

Es el encargado de alternar entre **Cam1** (TPS) y **Cam2** (FPS).

---

### 3️⃣ **Look.cs — Control de mirada del personaje**
Este script agrega un comportamiento adicional al personaje:
- Utiliza un objeto “Ojos” que siempre mira hacia un objetivo específico.
- Crea la sensación de que el personaje sigue el punto de interés o dirección de movimiento.
- Útil para animaciones, apuntado o interacción visual.

---

## 🧪 Estado del Prototipo
- Totalmente funcional como base para un sistema TPS/FPS híbrido.
- El cambio entre cámaras es estable y sencillo.
- Faltan mejorar suavizados, colisión de cámara y transiciones.
- Pensado como un proyecto experimental para entender cámaras sin frameworks externos.

---

## 🖼️ Imágenes del Proyecto

> Guardá tus capturas en una carpeta `/Images` y reemplazá los nombres en el README:

<p align="center">
  <img src="https://github.com/MiltonCastro93/OldSistemCameraScript/blob/main/Captura%20de%20pantalla%202025-11-17%20200523.png" width="500"/>
</p>

<p align="center">
  <img src="https://github.com/MiltonCastro93/OldSistemCameraScript/blob/main/Captura%20de%20pantalla%202025-11-17%20200535.png" width="500"/>
</p>

<p align="center">
  <img src="https://github.com/MiltonCastro93/OldSistemCameraScript/blob/main/Captura%20de%20pantalla%202025-11-17%20200545.png" width="500"/>
</p>

---

## 🛠️ Tecnologías
- **Unity** (versión utilizada en el prototipo)
- **C#** (control total del comportamiento de cámaras)

---

## 📌 Notas Finales
Este prototipo sirve como base para:
- TPS completos
- FPS con control avanzado
- Sistemas híbridos como GTA, Skyrim o Fallout

Si necesitás mejorar el sistema con:<br>
✔ transiciones suaves<br>
✔ colisión de cámara<br>
✔ FOV dinámico<br>
✔ sway de arma para FPS<br>
<br>
solo pedímelo y te lo preparo.
