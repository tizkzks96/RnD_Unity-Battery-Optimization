# RnD_Unity-Battery-Optimization
Unity Battery Optimization Test RnD


## Experimental method

1. Render the large size fbx in the waiting state.
2. [Rendering.OnDemandRendering-effectiveRenderFrameRate](https://docs.unity3d.com/2019.3/Documentation/ScriptReference/Rendering.OnDemandRendering-effectiveRenderFrameRate.html)Control the fps using Rendering.
3. Play for 3 hours at 60fps, 15fps, 0fps and compare battery consumption.


60 FPS   
![image](https://user-images.githubusercontent.com/11674965/163081429-70c076ee-6654-4b89-b1a9-97d708552fa2.png)  

3Hours
result : about 65%  
![image](https://user-images.githubusercontent.com/11674965/163105560-604f60b2-5bc9-4f00-a6d3-ea7ff872e43e.png)  

15 FPS
![image](https://user-images.githubusercontent.com/11674965/163738788-be0982be-f755-4a33-9512-f5006fdf250e.png)

3Hours
result : about 80%  
![image](https://user-images.githubusercontent.com/11674965/163738954-a36afd20-ec67-4aa5-b013-e9438c95afc5.png)


1FPS  
![image](https://user-images.githubusercontent.com/11674965/163081473-f327c3e9-e5d0-4db0-9213-4185f9915336.png)  

3Hours
result : about 80%  
![image](https://user-images.githubusercontent.com/11674965/163291310-02e25715-d157-499f-b782-54eb084c2776.png)  

60FPS -> 1FPS result 
- battery saving 18.75%  
- With fever -> No fever  

| 60FPS | 15FPS | 1 FPS |
| ------ | ------ | ------ |
| ![image](https://user-images.githubusercontent.com/11674965/163739159-8f83da0f-be63-46dd-aa65-654bf6e79d25.png) | ![image](https://user-images.githubusercontent.com/11674965/163739177-cf481878-e0b8-4148-8672-613d42b51487.png) | ![image](https://user-images.githubusercontent.com/11674965/163739181-18a9763f-1e40-4e91-bdb7-25441303b7c3.png) |
 

