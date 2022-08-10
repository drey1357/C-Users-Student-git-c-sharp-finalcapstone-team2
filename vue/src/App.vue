<template>
<div>
  <div id="app">
   
    
    <div class="grid-container">
      <img class="monster" src="https://www.clipartmax.com/png/full/154-1541145_fork-knife-comments-fork-and-knife-png.png" alt="Byte Logo"/>
      <h1 id="name">BYTE</h1>
      <!-- <img class="monster" src="https://www.clipartmax.com/png/full/154-1541145_fork-knife-comments-fork-and-knife-png.png"/>
    <h1 id="name">BYTE</h1> -->
     <div id="nav">
      <router-link v-bind:to="{ name: 'home'}">Home</router-link>&nbsp;|&nbsp;
      <router-link v-bind:to="{ name: 'logout' }" v-if="$store.state.token != ''">Logout</router-link>
      
    </div>
    </div>
    <router-view />
  </div>
  </div>
</template>

<style>
@import url('https://fonts.googleapis.com/css2?family=Play&display=swap');

body{
 width: 100vw;
 min-height: 100vh; 
 background-image: url("https://media.timeout.com/images/105843871/image.jpg");
 background-size: cover;
}

.grid-container{
  display: grid;
  grid-template-columns: 1fr 1fr 1fr;
  background-color: floralwhite;
  margin-left: auto;
  margin-right:auto;
  width: 75%;
  height: 100%;

 
}
.monster{
  width: 75px;
  height: 75px;
}

#name{
  font-family:  'Play', sans-serif;
  text-align: center;
  font-size: 50px;

}
#nav{
  font-family:  'Lusitana', serif;
  font-size: 15px;
  text-align: right;
  color: black;
}

</style>