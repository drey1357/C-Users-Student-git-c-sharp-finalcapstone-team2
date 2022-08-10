<template>
  <div class="home">
    <h1>Home</h1>
    <p> <em> If you can see this, you are authenticated </em></p>
    <p>welcome {{this.$store.state.user.username}}!</p>
   <preferences-table/>

    <button>setup matching sessions</button>
    <button>find new restaurants</button>
    <p>recommended restaurants:</p>
    <restaurant-card/>


  </div>
</template>

<script>
import PreferencesTable from "@/components/PreferencesTable.vue";
import RestaurantCard from '@/components/RestaurantCard.vue';

export default {
  name: "home",
  components:{
    PreferencesTable,
    RestaurantCard
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

</style>