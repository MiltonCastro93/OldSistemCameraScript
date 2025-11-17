# Camera Switch Prototype – Third ↔ First Person (Unity)

Este es un **prototipo simple y funcional** creado para experimentar el cambio dinámico de cámara entre **tercera persona** y **primera persona**, programado **completamente desde cero**, sin utilizar **Cinemachine** ni paquetes adicionales.

El objetivo del prototipo fue entender y dominar el manejo manual de cámaras, offsets, rotaciones y transiciones.

---

## 🎮 Características

### 🔄 Cambio de Cámara con un Botón
- Un solo botón alterna entre:
  - **Tercera Persona** (vista detrás del personaje)
  - **Primera Persona** (vista desde la cabeza del personaje)
- El cambio es instantáneo y sin dependencias externas.

### 📷 Cámaras Programadas Desde 0
- Sin Cinemachine.
- Control total sobre:
  - Posición relativa al personaje.
  - Rotación interpolada según el input del mouse.
  - Offsets personalizados asociados a cada modo de cámara.
- Código limpio para extender o integrar en futuros proyectos.

### 🧍 Control del Personaje
- Movimiento básico en tercera persona.
- En primera persona, el control rota directamente la vista.
- Cursor bloqueado en modo juego.

---

## 🧪 Estado del Prototipo
- Funcional como base para un sistema de cámara avanzado.
- No incluye combate, animaciones complejas ni interacción con objetos.
- Perfecto para continuar un TPS o FPS híbrido.

---

## 🖼️ Imágenes / Capturas

> Subí tus imágenes a una carpeta `/Images` dentro del repo y reemplazá los nombres:

<p align="center">
  <img src="Images/camera_tps.png" width="500"/>
</p>

<p align="center">
  <img src="Images/camera_fps.png" width="500"/>
</p>

---

## 🛠️ Tecnologías Utilizadas
- **Unity** (versión 2021)
- **C#** para el sistema de cámaras

---

## 📌 Notas Finales
Este prototipo sirve como base sólida para juegos que combinan ambas perspectivas.  
El sistema puede extenderse fácilmente añadiendo:
- Suavizado de transición
- Ajuste de FOV por modo
- Vibración o recoil en primera persona
- Colisión de cámara en tercera persona
