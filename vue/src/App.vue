<template>
  <div id="app">
    <div id="nav">
      <router-link v-bind:to="{ name: 'home'}">Home</router-link>&nbsp;|&nbsp;
      <router-link v-bind:to="{ name: 'logout' }" v-if="$store.state.token != ''">Logout</router-link>
      
    </div>
    <h1 id="name">B Y T E</h1>
    <div>
      <img class="monster" src="https://img.freepik.com/premium-vector/cute-monster-eating-pizza-cartoon-vector-illustration_607277-212.jpg?w=2000"/>
      </div>
    <router-view />
  </div>
</template>

<style>
@import url('https://fonts.googleapis.com/css2?family=Press+Start+2P&display=swap');

.monster{
  display: block;
  margin-left: auto;
  margin-right: auto;
  width: 200px;
  height: 200px;
}

#name{
  text-align: center;
  font-family:  'Press Start 2P', cursive;

}
#nav{
  text-align: center;
  font-family:  'Press Start 2P', cursive;
  font-size: 10px;
}




</style>