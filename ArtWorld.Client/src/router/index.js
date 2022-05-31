import { createRouter, createWebHistory } from 'vue-router'
// Public Views
import IndexView from '@/views/IndexView.vue'
import DetailsView from '@/views/DetailsView.vue'
// Admin Views
import AdminIndex from '@/views/admin/AdminIndex.vue'
import AnimeIndex from '@/views/admin/anime/Index.vue'
import AnimeCreate from '@/views/admin/anime/Create.vue'
import AnimeEdit from '@/views/admin/anime/Edit.vue'

const router = createRouter({
	history: createWebHistory(import.meta.env.BASE_URL),
	routes: [
		//Public Routes
		{
			path: '/',
			name: 'home',
			component: IndexView
		},
		{
			path: '/anime/:id',
			name: 'details',
			component: DetailsView
		},
		//Admin Routes
		{
			path: '/admin',
			name: 'admin',
    		component: AdminIndex,
    		children: [
				{ path: 'anime', name: 'animeIndex', component: AnimeIndex },
				{ path: 'anime/create', name: 'animeCreate', component: AnimeCreate },
				{ path: 'anime/edit/:id', name: 'animeEdit', component: AnimeEdit },
			]
		}
	]
})

export default router
