<template>
    <h1 id="tableLabel">Properties</h1>

    <p>Inventory from Roofstock.com</p>

    <p v-if="!properties"><em>Loading...</em></p>

    <table class='table table-striped' aria-labelledby="tableLabel" v-if="properties">
        <thead>
            <tr>
                <th>Address</th>
                <th class="numeric-column">Year Built</th>
                <th class="numeric-column">List Price</th>
                <th class="numeric-column">Monthly Rent</th>
                <th class="numeric-column">Gross Yield</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="property of properties" v-bind:key="property.id">
                <td>{{ property.address }}</td>
                <td class="numeric-column">{{ property.yearBuilt }}</td>
                <td class="numeric-column">{{ formatAsCurrency(property.listPrice) }}</td>
                <td class="numeric-column">{{ formatAsCurrency(property.monthlyRent) }}</td>
                <td class="numeric-column">{{ formatAsPercentage(property.grossYield) }}</td>
                <td><button @click="saveProperty(property)">Save</button></td>
            </tr>
        </tbody>
    </table>
</template>

<script>
    import axios from 'axios'
    export default {
        name: "Home",
        data() {
            return {
                properties: []
            }
        },
        methods: {
            async getProperties() {
                try {
                    const response = await axios.get('api/property');
                    this.properties = response.data;
                }
                catch (error) {
                    alert(error);
                }
            },
            async saveProperty(property) {
                try {
                    await axios.post('api/property', property);
                }
                catch (error) {
                    alert(error);
                }
            },
            formatAsCurrency(value) {
                var option = {
                    style: 'currency',
                    currency: 'USD'
                };

                var formatter = new Intl.NumberFormat('en-US', option);

                return formatter.format(value);
            },
            formatAsPercentage(value) {
                var option = {
                    style: 'percent',
                    minimumFractionDigits: 2,
                    maximumFractionDigits: 2
                };
                var formatter = new Intl.NumberFormat("en-US", option);

                return formatter.format(value);
            }
        },
        mounted() {
            this.getProperties();
        }
    }
</script>

<style scoped>
    th, td {
        text-align: left
    }

    .numeric-column {
        text-align: right;
    }
</style>