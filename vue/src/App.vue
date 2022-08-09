<template>
  <div id="app">
    <div id="nav">
      <router-link v-bind:to="{ name: 'home'}">Home</router-link>&nbsp;|&nbsp;
      <router-link v-bind:to="{ name: 'logout' }" v-if="$store.state.token != ''">Logout</router-link>
      
    </div>
    <div class="flex-container">
      <img class="monster" src="https://img.freepik.com/premium-vector/cute-monster-eating-pizza-cartoon-vector-illustration_607277-212.jpg?w=2000"/>
      
    <h1 id="name">BYTE</h1>
    </div>
    <router-view />
  </div>
</template>

<style>
@import url('https://fonts.googleapis.com/css2?family=Press+Start+2P&display=swap');

.flex-container{
  display: flex;
 

}
.monster{
  width: 125px;
  height: 125px;
}

#name{
  float: left;
  font-family:  'Press Start 2P', cursive;

}
#nav{
  text-align: end;
  font-family:  'Press Start 2P', cursive;
  font-size: 13px;
}

#app > div.home > div > table{
  
  margin: auto;
}

</style>