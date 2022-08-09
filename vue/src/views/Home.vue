<template>
<div class="flex-container2">
  <div class="home">
    <h1>Home</h1>
    <p> <em> If you can see this, you are authenticated </em></p>
    <p>welcome {{this.$store.state.user.username}}!</p>
   <preferences-table/>
   <br/>
   <div>

    <button>setup matching sessions</button>
    <button>find new restaurants</button>
    <p>recommended restaurants:</p>
</div>
  </div>
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

.flex-container2{
  display: flex;
  justify-content: center;
  background-color: floralwhite;
  margin-left: auto;
  margin-right:auto;
  width: 75%;
  height: 100%;
  
}
.home{
  text-align: center;
  background-color: floralwhite;
  font-family: 'Play', sans-serif;
}

#app > div.home > h1{
  font-family: 'Play', sans-serif;
  font-size: 20px;
}
/* #app > div.flex-container2 > div > button:nth-child(5){
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
#app > div.flex-container2 > div > button:nth-child(6){
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

#app > div.flex-container2 > div > button:nth-child(5):hover{
 
  background-color: darkgray;
}
#app > div.flex-container2 > div > button:nth-child(6):hover{

  background-color: darkgray;
} */


</style>