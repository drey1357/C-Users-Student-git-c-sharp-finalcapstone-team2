<template>
  <div class="home">
    <h1>Home</h1>
    <p> <em> If you can see this, you are authenticated </em></p>
    <p>welcome {{this.$store.state.user.username}}!</p>
   <preferences-table/>

    <button>setup matching sessions</button>
    <button>find new restaurants</button>
    <p>recommended restaurants:</p>


  </div>
</template>

<script>
import PreferencesTable from "@/components/PreferencesTable.vue";
export default {
  name: "home",
  components:{
    PreferencesTable
  }
};
</script>

<style>
.home{
  text-align: center;
}

#app > div.home > h1{
  font-family: 'Press Start 2P', cursive;
  font-size: 20px;
}
#app > div.home > button:nth-child(5){
  border: solid;
  border-width: .25px;
  border-radius: 15px;
  border-color: lightgray;
  margin-right: 5px;
  padding-top: 5px;
  padding-left: 15px;
  padding-bottom: 5px;
  padding-right: 15px;
  width: 200px;
}
#app > div.home > button:nth-child(6){
  border: solid;
  border-width: .25px;
  border-radius: 15px;
  border-color: lightgray;
  padding-top: 5px;
  padding-left: 15px;
  padding-bottom: 5px;
  padding-right: 15px;
  width: 200px;
}

#app > div.home > button:nth-child(5):hover{
 
  background-color: darkgray;
}
#app > div.home > button:nth-child(6):hover{

  background-color: darkgray;
}
</style>