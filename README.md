# RnD_Unity-Battery-Optimization
Unity Battery Optimization Test RnD


## Experimental method

1. Render the large size fbx in the waiting state.
2. [Rendering.OnDemandRendering-effectiveRenderFrameRate](https://docs.unity3d.com/2019.3/Documentation/ScriptReference/Rendering.OnDemandRendering-effectiveRenderFrameRate.html)Control the fps using Rendering.
3. Play for 3 hours at 60fps and 0fps and compare battery consumption.


60 FPS   
![image](https://user-images.githubusercontent.com/11674965/163081429-70c076ee-6654-4b89-b1a9-97d708552fa2.png)  

11:00~14:00  
result : about 65%  
![image](https://user-images.githubusercontent.com/11674965/163105560-604f60b2-5bc9-4f00-a6d3-ea7ff872e43e.png)  


1FPS  
![image](https://user-images.githubusercontent.com/11674965/163081473-f327c3e9-e5d0-4db0-9213-4185f9915336.png)  

16:00 ~ 19:00
result : about 80%  
![image](https://user-images.githubusercontent.com/11674965/163291310-02e25715-d157-499f-b782-54eb084c2776.png)  

as a result 
- battery saving 18.75%  
- With fever -> No fever
| before | after | 
|--------|-------|
![image](https://user-images.githubusercontent.com/11674965/163291349-cd5a19b2-92b4-4f78-943f-1058d4a4dcd0.png) | ![image](https://user-images.githubusercontent.com/11674965/163291355-46521ba2-0b90-4cfc-95ce-a9f99daffce4.png)

