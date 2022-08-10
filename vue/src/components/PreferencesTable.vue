<template>
  <div>
       <table name="preferences">
        <th>Your Preferences</th>
        <tr v-for="preference in preferences" v-bind:key="preference.preferenceId"> {{preference.preferenceType}}</tr>
        </table>
  </div>
</template>

<script>
import PreferencesService from "@/services/PreferencesService.js"

export default {
    name: "preferences-table",
    data(){
        return{
            preferences: [{
                preferenceId: 0,
                preferenceType: ""
            }]
        }
    },
    created(){
        PreferencesService.getPreferencesByUserId(this.$store.state.user.userId).then((response) => {
      let preferencesData = response.data;
      this.preferences = preferencesData;
    });
    }
}
</script>

<style>
#app > div.flex-container2 > div > div:nth-child(4) > table{
    align-items: center;
}

</style>